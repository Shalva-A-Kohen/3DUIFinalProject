using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Floor1GMBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //keyboard input
        if (Input.GetKeyDown("space"))
        {
            toFloorTwo();
        }
    }

    void toFloorTwo()
    {
        SceneManager.LoadScene("Floor2");
    }
}
