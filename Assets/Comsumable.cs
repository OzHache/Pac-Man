using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comsumable : MonoBehaviour
{
   
    private void OnTriggerEnter2D(Collider2D collider)
    {
        //needs to update scores
        //destroy
        DestroyObject(gameObject, 0f);
    }
}
