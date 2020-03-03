using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUp : MonoBehaviour
{
    float TotalTime;
    float ScoreRate = 1;
    float Score;

    void Update()
    {
        TotalTime += Time.deltaTime;
        Score = TotalTime * ScoreRate;
        Debug.Log("Score:");
    }

}

