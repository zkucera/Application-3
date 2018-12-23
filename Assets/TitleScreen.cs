using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitleScreen: MonoBehaviour
{
    public void Start()
    {
        DataManagement.datamanagement.loadData();
        
    }

    public void PlayPressed()
    {
        SceneManager.LoadScene(2);
    }

    public void LeaderBoardPressed()
    {
        SceneManager.LoadScene(3);
    }

    public void ExitPressed()
    {
        Application.Quit();
    }
}
