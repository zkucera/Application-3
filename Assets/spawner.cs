using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject[] objects;
    public List<GameObject> items = new List<GameObject>();
    public float spawnMin = 1f; //
    public float spawnMax = 2f; //
    public bool spawning = true;
    
    private GameObject item;

    private void Start()
    {
        GameObject.Find("pauseMenu").GetComponent<playerScore>().spawners.Add(this.gameObject);
        items = GameObject.Find("characterSpawner").GetComponent<characterSpawner>().items;
        Invoke("Spawn", Random.Range(spawnMin, spawnMax));

    }


    void Spawn()
    {
        if (spawning == true)
        {
            item = Instantiate(objects[Random.Range(0, objects.Length)], transform.position, Quaternion.identity);
            items.Add(item);
        }

        Invoke("Spawn", Random.Range(spawnMin, spawnMax));
    }
}
