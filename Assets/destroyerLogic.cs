using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyerLogic : MonoBehaviour
{


    private void OnTriggerEnter2D(Collider2D collision)  //To clean up blocks and enemies that have passed the character
    {
        if (collision.tag == "Player")
        {
            collision.gameObject.GetComponent<Player_Movement>().Death();
        }

            GameObject.Find("characterSpawner").GetComponent<characterSpawner>().items.Remove(collision.gameObject);
        Destroy(collision.gameObject);
    }


}
