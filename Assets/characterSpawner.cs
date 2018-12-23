using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class characterSpawner : MonoBehaviour
{
    public GameObject[] characters;
    public List<GameObject> items = new List<GameObject>();

    void Awake()
    {
        
        if (GameObject.Find("CharacterSelectCanvas").GetComponent<characterSelect>().selectedCharacter == "Knight")
        {
            Instantiate(characters[0], transform.position, Quaternion.identity);

        }
        else
        {
            Instantiate(characters[1], transform.position, Quaternion.identity);

        }

    }
    
}
