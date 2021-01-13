using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectInteractionScript : MonoBehaviour
{
   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Interact with only the object that has this script attached to it
    void OnMouseDown()
    {
        Debug.Log("This object has been clicked!");
    }
}
