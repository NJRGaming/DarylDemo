using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class AmIDead : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -12)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if(col.collider.gameObject.GetComponent<MeshRenderer>() != null)
        {
            if(col.collider.gameObject.GetComponent<MeshRenderer>().material.name == "RedMat (Instance)" && gameObject.name == "Player1")
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            } 
            if(col.collider.gameObject.GetComponent<MeshRenderer>().material.name == "BlueMat (Instance)" && gameObject.name == "Player2")
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
    }
}
