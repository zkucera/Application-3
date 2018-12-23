using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class knightUnlock : MonoBehaviour
{
    public GameObject knightButton;

    public void Start()
    {
        knightButton = GameObject.FindGameObjectWithTag("knightButton");
        if (DataManagement.datamanagement.knightUnlocked == false)
        {
            Vector3 pos = knightButton.transform.position;
            pos.x += 1000f;
            knightButton.transform.position = pos;
            GameObject.Find("knightUnlock").GetComponent<Text>().enabled = true;
            GameObject.Find("CharacterSelectCanvas").GetComponent<characterSelect>().moved = true;

        }
        else if (GameObject.Find("CharacterSelectCanvas").GetComponent<characterSelect>().moved == true)
        {

            Vector3 pos = knightButton.transform.position;
            pos.x -= 1000f;
            knightButton.transform.position = pos;
            GameObject.Find("knightUnlock").GetComponent<Text>().enabled = false;

        }


    }
}
