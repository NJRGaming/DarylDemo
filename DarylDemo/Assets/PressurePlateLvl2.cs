using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlateLvl2 : MonoBehaviour
{

    public GameObject groundChangeColorGameObject;
    public Material changeMaterial;
    private Material startMaterial;
    public Animator wallAnim;
    public static bool kill;
    // Start is called before the first frame update
    void Start()
    {
        startMaterial = groundChangeColorGameObject.GetComponent<MeshRenderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.CompareTag("Player"))
        {
            groundChangeColorGameObject.GetComponent<MeshRenderer>().material = changeMaterial;
            wallAnim.Play("WallDownLVL2");
            kill = !kill;
            
        }
    }
}
