using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.CompareTag("killPlayer"))
        {
             SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
