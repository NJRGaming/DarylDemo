using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puzzle1 : MonoBehaviour
{
    public GameObject wall;
    public GameObject wall2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void PassLevel()
    {
        
    }
    void OnCollisionStay(Collision collider)
    {
        if(collider.gameObject.CompareTag("Ball"))
        {
            Debug.Log("HELLO");
            Destroy(wall);
            PassLevel();
        }
    }

}
