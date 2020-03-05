using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverHighScore : MonoBehaviour
{
    public Text highscoreText;

    // Start is called before the first frame update
    void Start()
    {
        highscoreText.text = "HIGHSCORE: " + (int)PlayerPrefs.GetFloat("Highscore");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
