using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class DataManagement : MonoBehaviour
{
    public static DataManagement datamanagement;
    public List<int> scores = new List<int>();
    public bool knightUnlocked = false;

    void Awake()
    {
        if (datamanagement == null)
        {
            DontDestroyOnLoad(gameObject);
            datamanagement = this;
        }
        else if (datamanagement != this)
        {
            Destroy(gameObject);
        };
    }

    public void saveData(int score)
    {
        BinaryFormatter BinForm = new BinaryFormatter(); //Creates a binary formatter
        FileStream file = File.Open(Application.persistentDataPath + "/gameInfo34.dat",FileMode.Open);
        gameData data = new gameData(); //Creates container for data


        if (score >= 50) {
            data.knightUnlocked = true;

        }
        for(int i = 0; i <20; i++)
        {
          
            if (score > scores[i]) {

                scores.Insert(i, score);
                break;
            }
                
            else if(i == 19) { scores.Add(score); }
        }


        data.scores = scores;


        BinForm.Serialize(file, data); //serializes
        file.Close();
    }

    public void loadData()
    {
       
        if (File.Exists(Application.persistentDataPath + "/gameInfo34.dat"))
        {
            BinaryFormatter BinForm = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/gameInfo34.dat", FileMode.OpenOrCreate);
            gameData data = (gameData)BinForm.Deserialize(file);

            file.Close();
            scores = data.scores;
            knightUnlocked = data.knightUnlocked;

        }
        else
        {
            BinaryFormatter BinForm = new BinaryFormatter(); //Creates a binary formatter
            FileStream file = File.Create(Application.persistentDataPath + "/gameInfo34.dat"); //Creates file
            gameData data = new gameData(); //Creates container for data
            for (int i = 0; i < 20; i++) {
                data.scores.Add(0);
            }
            BinForm.Serialize(file, data); //serializes
            file.Close();
            scores = data.scores;
        }
    }

}


[Serializable]
class gameData
{
    public List<int> scores = new List<int>();
    public bool knightUnlocked = false;


}