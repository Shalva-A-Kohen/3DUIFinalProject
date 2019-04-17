using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MainGMBehavior : MonoBehaviour
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
            toFloorOne();
        }

        
    }

    void toFloorOne()
    {
        GameObject rayCam = GameObject.Find("UIRaycastCamera");
        GameObject acr = GameObject.Find("AsyncCoroutineRunner");
        DontDestroyOnLoad(rayCam);
        DontDestroyOnLoad(acr);

        SceneManager.LoadScene("Floor1");
    }
}
