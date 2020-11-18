using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpBall : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 offset;
    public GameObject ball;
    public Rigidbody ballRigidbody;
    public Transform handTransform;
    public LayerMask ballLayer;
    public LayerMask wallLayer;
    public float rangeToPickUp;
    bool canMove;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;
        if(Physics.Raycast(ray, out hitInfo, Mathf.Infinity, ballLayer) && Vector3.Distance(transform.position, hitInfo.collider.gameObject.transform.position) < rangeToPickUp && Input.GetMouseButtonDown(0))
        {
            Debug.Log(Vector3.Distance(transform.position, hitInfo.collider.gameObject.transform.position));
            if(hitInfo.collider.gameObject.name == "Ball")
            {
                canMove = true;
                

            }
        } 

        if(canMove && Input.GetMouseButton(0))
        {
            ball.transform.position = handTransform.position;


            

        } else {
            canMove = false;
        }
            if(Physics.Raycast(ray, out hitInfo, Mathf.Infinity, wallLayer) && Vector3.Distance(transform.position, hitInfo.collider.gameObject.transform.position) <= 5)
            {
                canMove = false;
            } 
            
        
    }


    
}
