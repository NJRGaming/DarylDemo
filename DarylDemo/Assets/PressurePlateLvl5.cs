﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlateLvl5 : MonoBehaviour
{
    public Animator wallAnim1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.CompareTag("Player"))
        {
            Debug.Log("Appoloo");
            wallAnim1.Play("PressurePlateDownLvl5");
        }
    }
}
