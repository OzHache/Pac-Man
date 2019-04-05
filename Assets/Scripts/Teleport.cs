﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform TeleportDestination;

    void OnTriggerEnter2D(Collider2D collider)
    {
        collider.gameObject.transform.position = TeleportDestination.position;
    }

}
