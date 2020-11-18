using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GroundLvl2 : MonoBehaviour
{
    Material material;
    bool shouldIKill;
    // Start is called before the first frame update
    void Start()
    {
        material = gameObject.GetComponent<MeshRenderer>().material;
    }    
    void Update()
    {
        if(gameObject.GetComponent<MeshRenderer>().material.name != "RedMat (Instance)")
        {
            shouldIKill = true;
        }else if(gameObject.GetComponent<MeshRenderer>().material.name == "RedMat (Instance)")
        {
            shouldIKill = false;
        }
    }
    void OnTriggerStay(Collider col)
    {
        if(col.gameObject.CompareTag("Player2"))
        {
            if(shouldIKill)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
            
        }
        
    }

    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.CompareTag("Player2"))
        {
            if(shouldIKill)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.CompareTag("Player"))
        {
            Debug.Log("ARE U FREAKING EATING MY TOES");
            if(!shouldIKill)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
            
        }

        if(col.gameObject.CompareTag("Player2"))
        {
            
            if(shouldIKill)
            {SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);}
        }
    }
}
