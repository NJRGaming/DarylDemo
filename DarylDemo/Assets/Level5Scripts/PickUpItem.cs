using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpItem : MonoBehaviour
{
    public LayerMask itemLayerMask;
    public GameObject pickUpGameObject;
    public GameObject secondCamera;
    public float distanceToPickUp;
    public Vector3 offset;
    bool canHold, isFacingWall;
    bool justLetGo;
    bool hasHeld;
    Rigidbody rb;
    Rigidbody pickedRb;
    public GameObject cursorGameObject;
    bool cantJump;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        pickedRb = pickUpGameObject.GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;
        if(Physics.Raycast(ray, out hitInfo, Mathf.Infinity, itemLayerMask) && Vector3.Distance(transform.position, hitInfo.collider.gameObject.transform.position) < distanceToPickUp)
        {
            if(hitInfo.collider.gameObject.tag == "Item")
            {
                canHold = true;


            } 
            
        }    else
        {
            canHold = false;
        }
        if(canHold && Input.GetMouseButton(0))
        {
            pickUpGameObject.layer = LayerMask.NameToLayer("PickedUp");
            canHold = true;
            pickUpGameObject.transform.position = secondCamera.transform.position + offset;
            pickUpGameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
            pickUpGameObject.GetComponent<Rigidbody>().useGravity = false;
            pickUpGameObject.tag = "CantJump";
            secondCamera.SetActive(true);
            hasHeld = true;
        }
        if(!Input.GetMouseButton(0) && hasHeld)
        {
            justLetGo = true; 
            canHold = false;
            hasHeld = false;
        }
        if(!canHold && justLetGo)
        {
            pickUpGameObject.tag = "Item";
            pickUpGameObject.transform.rotation = new Quaternion(GameObject.Find("MainCamera").transform.rotation.x, transform.rotation.y, 0, 0);
            pickUpGameObject.transform.position = cursorGameObject.transform.position;
            pickUpGameObject.GetComponent<Rigidbody>().useGravity = true;
            pickUpGameObject.layer =LayerMask.NameToLayer("BallLayer");
            justLetGo = false;
            canHold = false;
        }

        if(pickUpGameObject.transform.position.y > 1)
        {
            cantJump = true;
        }
        
    }

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.CompareTag("Wall") && hasHeld && isFacingWall)
        {
            rb.AddForce(-transform.forward * 1500);
        }
        if(col.gameObject.CompareTag("Ball"))
        {
            pickUpGameObject.tag = "CantJump";
        }
    }
    void OnCollisionStay(Collision col)
    {
        if(col.gameObject.CompareTag("Wall") && hasHeld && isFacingWall)
        {
            rb.AddForce(-transform.forward * 1500);
        }
    }
}
