using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnASpriteController : MonoBehaviour
{
    public GameObject[] Dice;
    public GameObject[] ShinyDice;
    // Spawn a die
    public void SpawnDice()
    {
        if (Random.value > 0.10)
        {
            GameObject tmp = Instantiate(Dice[UnityEngine.Random.Range(0, 6)]);
            tmp.transform.position = new Vector2(0, 0);
        }
        else
        {
            GameObject tmp = Instantiate(ShinyDice[UnityEngine.Random.Range(0, 6)]);
            tmp.transform.position = new Vector2(0, 0);
        }
    }
}
