using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuInteraction : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject AboutScreen;
    public GameObject TitleText;
    public GameObject NotAvailableScreen;

    //What happens when the player taps About This Game
    public void AboutGame()
    {
        MainMenu.SetActive(false);
        TitleText.SetActive(false);
        AboutScreen.SetActive(true);
        
    }

    //When player tries to access a feature that hasn't yet been implemented
    public void NotAvailable()
    {
        MainMenu.SetActive(false);
        TitleText.SetActive(false);
        NotAvailableScreen.SetActive(true);
    }

    //When Back button is tapped
    public void GoBack()
    {
        NotAvailableScreen.SetActive(false);
        AboutScreen.SetActive(false);
        TitleText.SetActive(true);
        MainMenu.SetActive(true);
    }

    //When Start button is tapped
    public void StartGame()
    {
        SceneManager.LoadScene("HotDogGame");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
