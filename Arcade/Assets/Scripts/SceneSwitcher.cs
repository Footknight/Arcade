using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
 

    // Goto Arcade
    public void GotoArcade()
    {
        SceneManager.LoadScene("Arcade");
    }

    //Goto HotDogGame
    public void GotoHotDogGame()
    {
        SceneManager.LoadScene("HotDogGame");
    }

  
}
