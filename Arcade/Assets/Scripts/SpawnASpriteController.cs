using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnASpriteController : MonoBehaviour
{
    public GameObject Dice;
    public GameObject ShinyDice;

    // Spawn a die
    public void SpawnDice()
    {
        if (Random.value > 0.01) //1% Spawn Chance
        {
            GameObject tmp = Instantiate(Dice);
            tmp.transform.position = new Vector2(0, 0);
        }
        else
        {
            GameObject tmp = Instantiate(ShinyDice);
            tmp.transform.position = new Vector2(0, 0);
        }
    }

   
}
