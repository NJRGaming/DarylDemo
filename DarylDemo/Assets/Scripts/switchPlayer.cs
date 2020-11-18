using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchPlayer : MonoBehaviour
{
    public GameObject Player_To_Switch;
    public GameObject PlayerModel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            Player_To_Switch.SetActive(true);
            gameObject.SetActive(false);

        }

        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Escaped");
            Application.Quit();
        }
    }
}
