using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetScore : MonoBehaviour
{
    public static int scoreValue = 0;
    Text score; 
    
    void Update()
    {
        score.text = "Score: " + scoreValue;
    }
}
