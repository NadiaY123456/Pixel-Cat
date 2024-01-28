using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] tilePrefabs;
    public GameObject[] fruits;
    //private Vector3 spawnPos = new Vector3(25,0,0);
    private float startDelay = 2;
    private float repeatRate = 2;
    private int num = 0;
    private playerController playerControllerScript;
    void Start()
    {
        InvokeRepeating("SpawnTile",startDelay,repeatRate);
        playerControllerScript = GameObject.Find("player").GetComponent<playerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnTile() {
        if (playerControllerScript.gameOver == false) {
            num++;
            float y = Random.Range(-1, 3);

            int index = Random.Range(0, fruits.Length);

            int index2 = Random.Range(0, tilePrefabs.Length);

            double spawn = Random.Range(0, 2);


            Vector2 spawnPos = new Vector2((float)0.7 + (float)6.8*num, y);
            Vector2 spawnPos2 = new Vector2((float)0.7 + (float)6.8*num, y + (float) 1.5);
            //int index = Random.Range(0, obstaclePrefabs.Length);
            Instantiate(tilePrefabs[index2], spawnPos, tilePrefabs[index2].transform.rotation);
            if (spawn < 0.6) {
                Instantiate(fruits[index], spawnPos2, fruits[index].transform.rotation);
                Debug.Log(spawn);
            }
            
        }
    }
}
