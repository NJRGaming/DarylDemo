using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
    // Start is called before the first fr
    bool isJumping;
    Rigidbody rigidbody;
    public float jumpMoveSpeed; 
    void Start()
    {
        rigidbody = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(rigidbody.velocity.y > 0)
        {
            if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
            {
                rigidbody.AddForce(transform.forward * (jumpMoveSpeed - 1), ForceMode.Impulse);
            }
            if(Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
            {
                rigidbody.AddForce(transform.forward * -jumpMoveSpeed, ForceMode.Impulse);
            }
            if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                rigidbody.AddForce(transform.right * jumpMoveSpeed, ForceMode.Impulse);
            }
            if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                rigidbody.AddForce(transform.right * -jumpMoveSpeed, ForceMode.Impulse);
            }
        }

        
    }

   
}
