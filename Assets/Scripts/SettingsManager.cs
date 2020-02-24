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

    public int resWidth;
    public int resHeight;

    // Start is called before the first frame update
    void Start()
    {
        resWidth = Screen.currentResolution.width;
        resHeight = Screen.currentResolution.height;
    }

    // Update is called once per frame
    void Update()
    {
        

        resolutionIntWidth = Mathf.RoundToInt(resWidth * resolutionSlider.value);
        resolutionIntHeight = Mathf.RoundToInt(resHeight * resolutionSlider.value);

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
