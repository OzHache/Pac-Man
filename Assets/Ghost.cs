using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ghost : MonoBehaviour
{
    public Sprite BlueGhost;

    public void MakeVulnerable()
    {
        /*
         * Turn blue
         * turn off damage
         * turn on consumable
         */
        gameObject.GetComponent<SpriteRenderer>().sprite = BlueGhost;
        gameObject.GetComponent<Damage>().Vulnerable = true;
    }
}
