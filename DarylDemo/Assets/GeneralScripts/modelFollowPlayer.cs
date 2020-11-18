using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class modelFollowPlayer : MonoBehaviour
{

    //set it to blue or red.
    public GameObject player;
    public Vector3 offset;
    private Collider hitBox;
    public GameObject[] bodyDisable;
    void Start()
    {
        hitBox = gameObject.GetComponent<Collider>();
    }
    void Update()
    {
        if(player.activeSelf == false)
        {
            hitBox.enabled = true;
            foreach (Transform child in transform)
            {child.gameObject.SetActive(true);}

        }
        if(player.activeSelf == true)
        {
            hitBox.enabled = false;
            foreach (Transform child in transform)
            {child.gameObject.SetActive(false);}

        }


        transform.position = player.transform.position + offset;
        transform.rotation = player.transform.rotation;
    }
}
