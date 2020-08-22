using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneSwitcher : MonoBehaviour
{
 

    // Goto Arcade
    public void GotoArcade()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Arcade");
    }

    //Goto HotDogGame
    public void GotoHotDogGame()
    {
        SceneManager.LoadScene("HotDogGame");
    }

    //If player taps Back to Main Menu
    public void BackToMain()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("HotDogGameTitleScreen");
    }

  
}
