using System.Collections;

using System.Collections.Generic;

using UnityEngine;



public class PlayspaceBehavior : MonoBehaviour

{

    // Start is called before the first frame update

    public CameraBehavior cB;



    void Awake()

    {

        DontDestroyOnLoad(this.gameObject);

        cB = GameObject.FindWithTag("MainCamera").GetComponent<CameraBehavior>();

    }



    // Update is called once per frame

    void Update()

    {



    }



    public void useStairs12L()

    {

        int cFloor = cB.currentFloor;



        if (cFloor == 1)

        {

            transform.position = new Vector3(-3.32f, -0.81f, 11.01f);

        }

        else if (cFloor == 2)

        {

            transform.position = new Vector3(-3.32f, -3.29f, 12.36f);

        }

    }

    public void useStairs12R()

    {

        int cFloor = cB.currentFloor;



        if (cFloor == 1)

        {

            transform.position = new Vector3(0.19f, -0.78f, 13.36f);

        }

        else if (cFloor == 2)

        {

            transform.position = new Vector3(-1.65f, -3.29f, 13.28f);

        }

    }

    public void useStairs23L()

    {

        int cFloor = cB.currentFloor;



        if (cFloor == 2)

        {

            transform.position = new Vector3(-6.41f, 1.24f, 15.56f);

        }

        else if (cFloor == 3)

        {

            transform.position = new Vector3(-4.08f, -0.81f, 17.41f);

        }

    }

}