using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordSpawner : MonoBehaviour
{
    public GameObject wordPrefeb;
    public Transform wordCanvas;


    public WordDisplay SpawnWord()
    {
        Vector3 randomPosition = new Vector3(Random.Range(-5.5f, 5.5f), 7f);
        GameObject wordObj = Instantiate(wordPrefeb, randomPosition, Quaternion.identity, wordCanvas);
        WordDisplay wordDisplay = wordObj.GetComponent<WordDisplay>();

        return wordDisplay;
    }
}

