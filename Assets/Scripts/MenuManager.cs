using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public string sceneName;
    public GameObject mainMenu;
    public GameObject settings;
    public bool settingsOpen = false;
    public bool menuOpen = true;

    public void LoadScene()
    {
        SceneManager.LoadScene(sceneName);
    }

    public void QuitGame()
    {
        Application.Quit();
        
    }

    public void OpenSettings()
    {
        
        if (mainMenu.activeInHierarchy == true)
        {
            settingsOpen = true;
            menuOpen = false;
            mainMenu.SetActive(false);
            settings.SetActive(true);            
        }

    }
    
    public void OpenMenu()
    {
        if (settings.activeInHierarchy == true)
        {
            settingsOpen = false;
            menuOpen = true;
            mainMenu.SetActive(true);
            settings.SetActive(false);
        }

    }

}
