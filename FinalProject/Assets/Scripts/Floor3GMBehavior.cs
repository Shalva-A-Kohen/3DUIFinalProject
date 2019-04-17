using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Floor3GMBehavior : MonoBehaviour
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
            toFloorFour();
        }
    }

    void toFloorFour()
    {
        SceneManager.LoadScene("Floor4");
    }
}
