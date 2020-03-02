using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScorePerSecond : MonoBehaviour
{
    public Text scoreText;
    public float scoreAmount;
    public float pointIncreaseBySecond;

    // Start is called before the first frame update
    void Start()
    {
        scoreAmount = 0;
        pointIncreaseBySecond = 1;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = (int)scoreAmount + "";
        scoreAmount +=pointIncreaseBySecond * Time.deltaTime*2;
    }
}
