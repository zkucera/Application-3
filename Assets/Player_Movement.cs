using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Player_Movement : MonoBehaviour
{

    public float moveSpeed = 0.09f; //The block's movement speed
    public float speedUp = 0.0001f;  //The rate at which the movement speed increases
    public int playerJumpPower= 1250;//Constant to adjust the height of a player jump
    public GameObject deathCanvas; // For displaying death message
    public float maxFallingVelocity = -12; // The fastest speed the character can fall
    public bool characterSelect = true;  //Decide between ninja and knight
    public List<GameObject> spawners = new List<GameObject>();
    public List<GameObject> blocks = new List<GameObject>();



    // Update is called once per frame
    private void Start()
    {
        deathCanvas = GameObject.Find("YOU DIED");
        blocks = GameObject.Find("characterSpawner").GetComponent<characterSpawner>().items;
        spawners = GameObject.Find("pauseMenu").GetComponent<playerScore>().spawners;

    }

    void Update()
    {
        PlayerMove();

        moveSpeed += speedUp;
        if (gameObject.GetComponent<Rigidbody2D>().velocity.y <= 0 && gameObject.GetComponent<Rigidbody2D>().velocity.y > -0.5) gameObject.GetComponent<Animator>().SetBool("isGrounded", true);
        else gameObject.GetComponent<Animator>().SetBool("isGrounded", false);
        
        
    }


    void PlayerMove() {
        //Controls
        if (Input.GetButtonDown("Jump") && gameObject.GetComponent<Rigidbody2D>().velocity.y == 0)  // Jump default is spacebar, only jump if the player is on the ground
        {
            Jump();
        }

        if (Input.GetKeyDown(KeyCode.A)) //Attack button is pressed
        {
            StartCoroutine(Attack());

        }

        //Control Falling Speed
        float curSpeed = gameObject.GetComponent<Rigidbody2D>().velocity.y;
        if (curSpeed < maxFallingVelocity)
        {
            float reduction = maxFallingVelocity / curSpeed;
            gameObject.GetComponent<Rigidbody2D>().velocity *= reduction;
        }
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "Enemy")
        {
            GameObject.Find("characterSpawner").GetComponent<characterSpawner>().items.Remove(collision.gameObject);
            GameObject.Find("pauseMenu").GetComponent<playerScore>().score += 10;
            Destroy(collision.gameObject);
            // collision.gameObject.GetComponent<Mobs>().Death(); //Trigger the enemy's death function when hit
        }
    }

    

    IEnumerator Attack()
    {
        gameObject.GetComponent<Animator>().SetTrigger("attackTrigger"); //Play attack animation
        gameObject.GetComponent<BoxCollider2D>().enabled = true; //Enable hitbox
        yield return new WaitForSeconds(0.5f);  //Wait
        gameObject.GetComponent<BoxCollider2D>().enabled = false; //Disable hit box
    }


    void Jump()
    {
        GetComponent<Rigidbody2D>().AddForce(Vector2.up * playerJumpPower); //Add a vertical force to the player
    }

    public void Death()
    {
        GameObject.Find("pauseMenu").GetComponent<playerScore>().enabled = false;
        deathCanvas.GetComponent<Canvas>().enabled = true;
        gameObject.GetComponent<Player_Movement>().enabled = false;
        gameObject.GetComponent<Animator>().enabled = false;
        gameObject.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll; //Freeze Character on pause

        foreach (GameObject spawner in spawners) //Stop the spawning of enemies and blocks
        {

            spawner.GetComponent<spawner>().spawning = false;
        }


        foreach (GameObject item in blocks) //Turn off block and enemy movement
        {
            if (item)
            item.GetComponent<obstacleMovement>().enabled = false;

        }

        DataManagement.datamanagement.saveData((int)GameObject.Find("pauseMenu").GetComponent<playerScore>().score);

    }
}
