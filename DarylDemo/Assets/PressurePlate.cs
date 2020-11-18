using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour
{
    public Animator wallAnim;
    public GameObject signGameobject;

    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.CompareTag("Player") && gameObject.name == "PressurePlate1")
        {
            wallAnim.Play("wallDown1");
        }
        if(col.gameObject.CompareTag("Player") && gameObject.name == "PressurePlate2")
        {
            wallAnim.Play("wallDown2");
            Destroy(signGameobject);
        }
    }
    void OnTriggerExit(Collider col)
    {
        if(col.gameObject.CompareTag("Player") && gameObject.name == "PressurePlate1")
        {
            wallAnim.Play("wallUp1");
        }
        if(col.gameObject.CompareTag("Player") && gameObject.name == "PressurePlate2")
        {
            wallAnim.Play("wallUp2");
            Destroy(signGameobject);
        }
    }
}
