using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public bool Vulnerable = false;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            if (!Vulnerable)
            {
                Debug.Log("You've Died :( ");

                //todo: ref in GM and lose life
                GameManager.GetGameManager.LivesUpdate();
            }
            else
            {
                Debug.Log("I've Died :) ");
                Vulnerable = false;
                //todo: send Ghost home and reset
            }
        }
    }
}
