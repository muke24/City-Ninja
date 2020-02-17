using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsManager : MonoBehaviour
{
    public Slider volumeSlider;
    public Slider resolutionSlider;

    public Text volumeText;
    public Text resolutionText;
    public Text resolutionSize;

    public string resText;

    public int volumeInt;
    public int resolutionIntWidth;
    public int resolutionIntHeight;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        resolutionIntWidth = Mathf.RoundToInt(Screen.currentResolution.width * resolutionSlider.value);
        resolutionIntHeight = Mathf.RoundToInt(Screen.currentResolution.height * resolutionSlider.value);

        resolutionText.text = resText;
        resText = resolutionSlider.value.ToString();
        if (resText.Length > 3)
        {
            resText = resText.Substring(0, 3);
        }

        volumeInt = Mathf.RoundToInt(volumeSlider.value);
        volumeText.text = volumeSlider.value.ToString() + "%";
        

        resolutionSize.text = resolutionIntWidth.ToString() + " x " + resolutionIntHeight.ToString();
    }

    public void ApplySettings()
    {
        Screen.SetResolution(resolutionIntWidth, resolutionIntHeight, FullScreenMode.ExclusiveFullScreen);
    }
}
