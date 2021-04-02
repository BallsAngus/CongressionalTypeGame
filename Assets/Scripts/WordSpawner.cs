using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordSpawner : MonoBehaviour
{
    public GameObject wordPrefab;
    public GameObject wordPrefab2;
    public Transform wordCanvas;
    public GameObject[] shipList = new GameObject[2];
    Transform theCamera;

    private int numRed = 0;

    private void Start()
    {
        shipList[0] = wordPrefab;
        shipList[1] = wordPrefab2;
        theCamera = Camera.main.transform;
    }

    public WordDisplay SpawnWord()
    {
        int shipID = Random.Range(0,2);
        if(shipID == 0)
        {
            numRed++;
            if(numRed == 3)
            {
                shipID = 1;
                numRed = 0;
            }
        }
        else
        {
            shipID = 0;
        }
        GameObject wordToSpawn = shipList[shipID];
        Vector3 randomPosition = new Vector3(Random.Range(-4f, 4f), 7f + theCamera.position.y);
        GameObject wordObj = Instantiate(wordToSpawn, randomPosition, Quaternion.identity, wordCanvas);
        WordDisplay wordDisplay = wordObj.GetComponent<WordDisplay>();
        return wordDisplay;
    }
}
