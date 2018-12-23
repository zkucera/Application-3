using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Leaderboad : MonoBehaviour
{


    void Start()
    {
        DataManagement.datamanagement.loadData();
        for (int i = 0; i < DataManagement.datamanagement.scores.Count; i++)
        {
            if (i == 0) {
                GameObject.Find("highscore").GetComponent<Text>().text += DataManagement.datamanagement.scores[i].ToString();
                GameObject.Find("highscore").GetComponent<Text>().text = GameObject.Find("highscore").GetComponent<Text>().text.Replace("\n", "");
            }
            if (i == 1)
            {
                GameObject.Find("2nd").GetComponent<Text>().text += DataManagement.datamanagement.scores[i].ToString();
                GameObject.Find("2nd").GetComponent<Text>().text = GameObject.Find("2nd").GetComponent<Text>().text.Replace("\n", "");
            }
            if (i == 2)
            {
                GameObject.Find("3rd").GetComponent<Text>().text += DataManagement.datamanagement.scores[i].ToString();
                GameObject.Find("3rd").GetComponent<Text>().text = GameObject.Find("3rd").GetComponent<Text>().text.Replace("\n", "");
            }
            if (i == 3)
            {
                GameObject.Find("4th").GetComponent<Text>().text += DataManagement.datamanagement.scores[i].ToString();
                GameObject.Find("4th").GetComponent<Text>().text = GameObject.Find("4th").GetComponent<Text>().text.Replace("\n", "");
            }
            if (i == 4)
            {
                GameObject.Find("5th").GetComponent<Text>().text += DataManagement.datamanagement.scores[i].ToString();
                GameObject.Find("5th").GetComponent<Text>().text = GameObject.Find("5th").GetComponent<Text>().text.Replace("\n", "");
            }
            if (i == 5)
            {
                GameObject.Find("6th").GetComponent<Text>().text += DataManagement.datamanagement.scores[i].ToString();
                GameObject.Find("6th").GetComponent<Text>().text = GameObject.Find("6th").GetComponent<Text>().text.Replace("\n", "");
            }
            if (i == 6)
            {
                GameObject.Find("7th").GetComponent<Text>().text += DataManagement.datamanagement.scores[i].ToString();
                GameObject.Find("7th").GetComponent<Text>().text = GameObject.Find("7th").GetComponent<Text>().text.Replace("\n", "");
            }
            if (i == 7)
            {
                GameObject.Find("8th").GetComponent<Text>().text += DataManagement.datamanagement.scores[i].ToString();
                GameObject.Find("8th").GetComponent<Text>().text = GameObject.Find("8th").GetComponent<Text>().text.Replace("\n", "");
            }
            if (i == 8)
            {
                GameObject.Find("9th").GetComponent<Text>().text += DataManagement.datamanagement.scores[i].ToString();
                GameObject.Find("9th").GetComponent<Text>().text = GameObject.Find("9th").GetComponent<Text>().text.Replace("\n", "");
            }
            if (i == 9)
            {
                GameObject.Find("10th").GetComponent<Text>().text += DataManagement.datamanagement.scores[i].ToString();
                GameObject.Find("10th").GetComponent<Text>().text = GameObject.Find("10th").GetComponent<Text>().text.Replace("\n", "");
            }
            if (i == 10)
            {
                GameObject.Find("11th").GetComponent<Text>().text += DataManagement.datamanagement.scores[i].ToString();
                GameObject.Find("11th").GetComponent<Text>().text = GameObject.Find("11th").GetComponent<Text>().text.Replace("\n", "");
            }
            if (i == 11)
            {
                GameObject.Find("12th").GetComponent<Text>().text += DataManagement.datamanagement.scores[i].ToString();
                GameObject.Find("12th").GetComponent<Text>().text = GameObject.Find("12th").GetComponent<Text>().text.Replace("\n", "");
            }
            if (i == 12)
            {
                GameObject.Find("13th").GetComponent<Text>().text += DataManagement.datamanagement.scores[i].ToString();
                GameObject.Find("13th").GetComponent<Text>().text = GameObject.Find("13th").GetComponent<Text>().text.Replace("\n", "");
            }
            if (i == 13)
            {
                GameObject.Find("14th").GetComponent<Text>().text += DataManagement.datamanagement.scores[i].ToString();
                GameObject.Find("14th").GetComponent<Text>().text = GameObject.Find("14th").GetComponent<Text>().text.Replace("\n", "");
            }
            if (i == 14)
            {
                GameObject.Find("15th").GetComponent<Text>().text += DataManagement.datamanagement.scores[i].ToString();
                GameObject.Find("15th").GetComponent<Text>().text = GameObject.Find("15th").GetComponent<Text>().text.Replace("\n", "");
            }
            if (i == 15)
            {
                GameObject.Find("16th").GetComponent<Text>().text += DataManagement.datamanagement.scores[i].ToString();
                GameObject.Find("16th").GetComponent<Text>().text = GameObject.Find("16th").GetComponent<Text>().text.Replace("\n", "");
            }
            if (i == 16)
            {
                GameObject.Find("17th").GetComponent<Text>().text += DataManagement.datamanagement.scores[i].ToString();
                GameObject.Find("17th").GetComponent<Text>().text = GameObject.Find("17th").GetComponent<Text>().text.Replace("\n", "");
            }
            if (i == 17)
            {
                GameObject.Find("18th").GetComponent<Text>().text += DataManagement.datamanagement.scores[i].ToString();
                GameObject.Find("18th").GetComponent<Text>().text = GameObject.Find("18th").GetComponent<Text>().text.Replace("\n", "");
            }
            if (i == 18)
            {
                GameObject.Find("19th").GetComponent<Text>().text += DataManagement.datamanagement.scores[i].ToString();
                GameObject.Find("19th").GetComponent<Text>().text = GameObject.Find("19th").GetComponent<Text>().text.Replace("\n", "");
            }
            if (i == 19)
            {
                GameObject.Find("pooscore").GetComponent<Text>().text += DataManagement.datamanagement.scores[i].ToString();
                GameObject.Find("pooscore").GetComponent<Text>().text = GameObject.Find("pooscore").GetComponent<Text>().text.Replace("\n", "");
            }
            
        }
    }

    public void backButtonPressed()
    {
        SceneManager.LoadScene(0);
    }
}
