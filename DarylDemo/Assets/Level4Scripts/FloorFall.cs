﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorFall : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        Destroy(gameObject);
    }
}
