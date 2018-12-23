using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class obstacleMovement : MonoBehaviour
{
    public GameObject player;
    public float moveSpeed;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }


    private void FixedUpdate()
    {
        if (player)
        {
            moveSpeed = player.GetComponent<Player_Movement>().moveSpeed;
        }
   
        gameObject.GetComponent<Transform>().position = gameObject.GetComponent<Transform>().position - new Vector3(moveSpeed, 0f, 0f);
    }



}
