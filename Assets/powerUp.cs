using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerUp : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            collision.GetComponent<Player_Movement>().moveSpeed += 0.01f;
            collision.GetComponent<Player_Movement>().playerJumpPower += 50;
            if (collision.GetComponent<Rigidbody2D>().gravityScale >= 5) collision.GetComponent<Rigidbody2D>().gravityScale -=1;
            GameObject.Find("pauseMenu").GetComponent<playerScore>().score += 10;

            Destroy(gameObject);
        }
    }
}
