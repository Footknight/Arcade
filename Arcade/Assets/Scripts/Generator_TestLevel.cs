using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator_TestLevel : MonoBehaviour
{
    public GameObject brick;
    public GameObject brick1;
    
    // Start is called before the first frame update
    void Start()
    {
        if(Random.value > 0.5)
        {
            GameObject tmp = Instantiate(brick);
            tmp.transform.position = new Vector2(0, 0);
        }
        else
        {
            GameObject tmp = Instantiate(brick1);
            tmp.transform.position = new Vector2(0, 0);
        }
        if (Random.value > 0.5)
        {
            GameObject tmp = Instantiate(brick);
            tmp.transform.position = new Vector2(1, 0);
        }
        else
        {
            GameObject tmp = Instantiate(brick1);
            tmp.transform.position = new Vector2(1, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
