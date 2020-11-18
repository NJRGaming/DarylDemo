using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raycast : MonoBehaviour
{
    public LayerMask layer;
    bool isWithinDistance;
    public Animator buttonAnim;
    public Animator buttonAnim2;
    public bool isPressed;

    public GameObject platform1, platform2, platform3;
    public AudioSource audioClip;
    bool canPress1 = true, canPress2 = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;
        if(Physics.Raycast(ray, out hitInfo, Mathf.Infinity, layer) && Vector3.Distance(transform.position, hitInfo.collider.gameObject.transform.position) < 6 && Input.GetMouseButtonDown(0))
        {
            Debug.Log(Vector3.Distance(transform.position, hitInfo.collider.gameObject.transform.position));
            if(hitInfo.collider.gameObject.name == "Button1" && canPress1 == true)
            {
                platform1.SetActive(false);
                platform2.SetActive(true);
                buttonAnim.Play("buttonAnim");
                audioClip.Play();
                canPress1 = false;
            }
            if(hitInfo.collider.gameObject.name == "Button2" && canPress2 == true)
            {
                buttonAnim2.Play("buttonAnim");
                platform2.SetActive(false);
                platform3.SetActive(true);
                audioClip.Play();
                canPress2 = false;
            }
        }
    }



}
