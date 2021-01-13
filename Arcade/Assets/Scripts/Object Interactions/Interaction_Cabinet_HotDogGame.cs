using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction_Cabinet_HotDogGame : MonoBehaviour
{
    public GameObject UI_Start_HotDogGame;  
  

    //Call up the HotDogGame arcade cabinet prompt
    public void OnMouseDown()
    {
        Time.timeScale = 0;
        Cursor.visible = true;
        UI_Start_HotDogGame.SetActive(true);
        
    }

    public void Update()
    {
        if(Input.GetButtonDown("Cancel"))
        {
            Time.timeScale = 1;
            Cursor.visible = false;
            UI_Start_HotDogGame.SetActive(false);
        }
    }
}
