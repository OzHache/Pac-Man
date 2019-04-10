using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigPellet : Consumable
{
    // Start is called before the first frame update
    void Start()
    {
        ScoreValue = 20;
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        GameManager.GetGameManager.EatGhost();

    }
    //makes the ghost consumeable
}
