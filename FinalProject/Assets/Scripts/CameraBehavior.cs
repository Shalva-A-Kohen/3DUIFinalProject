using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehavior : MonoBehaviour
{

    public float mapPosX;
    public float mapPosY;
    public int currentFloor;

    public GameObject floor1Minimap;
    public GameObject floor2Minimap;
    public GameObject floor3LMinimap;
    public GameObject floor3RMinimap;
    public GameObject floor4Minimap;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 currentPos = transform.position;
        mapPosX = currentPos.x;
        mapPosY = currentPos.z;
        currentFloor = 1;
    }

    // Update is called once per frame
    void Update()
    {
        getMapPos();
    }

    void OnCollisionEnter(Collision collision)
    {
        string floorname = collision.gameObject.name;
        if(floorname == "Floor1")
        {
            currentFloor = 1;
            deactivateAllFloor();
            floor1Minimap.SetActive(true);
        }
        else if(floorname == "Floor2")
        {
            currentFloor = 2;
            deactivateAllFloor();
            floor2Minimap.SetActive(true);
        }
        else if (floorname == "Floor3L")
        {
            currentFloor = 3;
            deactivateAllFloor();
            floor3LMinimap.SetActive(true);
        }
        else if (floorname == "Floor3R")
        {
            currentFloor = 3;
            deactivateAllFloor();
            floor3RMinimap.SetActive(true);
        }
        else if (floorname == "Floor4")
        {
            currentFloor = 4;
            deactivateAllFloor();
            floor4Minimap.SetActive(true);
        }

        Debug.Log(currentFloor);
    }

    private void deactivateAllFloor()
    {
        floor1Minimap.SetActive(false);
        floor2Minimap.SetActive(false);
        floor3RMinimap.SetActive(false);
        floor3LMinimap.SetActive(false);
        floor4Minimap.SetActive(false);
    }
    private void getMapPos()
    {
        Vector3 currentPos = transform.position;
        mapPosX = currentPos.x;
        mapPosY = currentPos.z;
    }

}
