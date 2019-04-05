using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Consumable : MonoBehaviour
{
    public int ScoreValue;
   
    private void OnTriggerEnter2D(Collider2D collider)
    {
        //needs to update scores
        GameManager.GetGameManager.ScoreUpdate(ScoreValue);
        //destroy
        Destroy(gameObject, 0f);
    }
    
}
