using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class characterSelect : MonoBehaviour
{
    public string selectedCharacter;
    public GameObject knightButton;
    public bool moved;
    private static characterSelect instance = null;

    private void Awake()
    {
        

        GameObject.Find("CharacterSelectCanvas").GetComponent<Canvas>().enabled = true;

        DontDestroyOnLoad(this);

        if (instance == null)
        {
            instance = this;
        }
        else Destroy(gameObject);


    }

 

    private void OnDisable()
    {
        
    }



    public void selectKnight()
    {
            selectedCharacter = "Knight";
            GameObject.Find("CharacterSelectCanvas").GetComponent<Canvas>().enabled = false;
            SceneManager.LoadScene(1);       
    }


    public void selectNinja()
    {
        selectedCharacter = "Ninja";

        GameObject.Find("CharacterSelectCanvas").GetComponent<Canvas>().enabled = false;

        SceneManager.LoadScene(1);

        

    }
}

