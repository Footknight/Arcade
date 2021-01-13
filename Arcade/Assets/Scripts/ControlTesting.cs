using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlTesting : MonoBehaviour
{

    public Transform ControlThisObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            ControlThisObject.position = new Vector3(-1, 0, 0);
        }
        if (Input.GetKey("d"))
        {
            ControlThisObject.TransformDirection(1, 0, 0);
        }
        if (Input.GetKey("s"))
        {
            ControlThisObject.TransformDirection(0, 1, 0);
        }
        if (Input.GetKey("w"))
        {
            ControlThisObject.TransformDirection(0, -1, 0);
        }
    }
}
