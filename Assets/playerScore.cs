using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playerScore : MonoBehaviour
{
    public GameObject scoreUI;
    public float score;
    public bool isPaused = false;
    public GameObject pauseMenu;
    public GameObject player;
    public List<GameObject> spawners = new List<GameObject>();
    public List<GameObject> blocks = new List<GameObject>();

    private void Start()
    {
       
        scoreUI = GameObject.Find("scoreUI");
        pauseMenu = GameObject.Find("pauseMenu");
        player = GameObject.FindGameObjectWithTag("Player");
        blocks = GameObject.Find("characterSpawner").GetComponent<characterSpawner>().items;
       
    }

    void Update()
    {
        scoreUI = GameObject.Find("scoreUI");

        if (isPaused == false)
        { //Only count the time when the game is unpaused
            score += Time.deltaTime;
            scoreUI.GetComponent<Text>().text = "Score: " + ((int)score).ToString();
        }

        if (Input.GetKeyDown(KeyCode.Escape ) && isPaused == false) //When the player presses esc, bring up the pause menu
        {
            
            pauseMenu.GetComponent<Canvas>().enabled = true;
            player.GetComponent<Player_Movement>().enabled = false;
            player.GetComponent<Animator>().enabled = false;
            
            foreach (GameObject spawner in spawners) //Stop the spawning of enemies and blocks
            {
                
                spawner.GetComponent<spawner>().spawning = false;
            }


            foreach (GameObject item in blocks) //Turn off block and enemy movement
            {
                if (item)
                item.GetComponent<obstacleMovement>().enabled = false;
            }

        
            player.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll; //Freeze Character on pause
            isPaused = true;


        }

        else if (Input.GetKeyDown(KeyCode.Escape) && isPaused == true)
        {
            isPaused = false;
            pauseMenu.GetComponent<Canvas>().enabled = false;
            player.GetComponent<Player_Movement>().enabled = true;

            foreach (GameObject spawner in spawners) //Start the spawning of enemies and blocks
            {
                spawner.GetComponent<spawner>().spawning = true;
            }

            foreach (GameObject item in GameObject.Find("characterSpawner").GetComponent<characterSpawner>().items) //Turn on the block and enemy movement
            {
                if (item)
                    item.GetComponent<obstacleMovement>().enabled = true;
            }

            player.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezeRotation; //Unfreeze character on resume
            player.GetComponent<Animator>().enabled = true;
        }

    }


    public void restartPressed()
    {
        SceneManager.LoadScene(1);

    }

    public void exitPressed()
    {
       SceneManager.LoadScene(0);
    }
}
