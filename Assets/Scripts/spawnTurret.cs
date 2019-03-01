using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnTurret : MonoBehaviour
{
    public GameObject turretPrefab;
    bool isPressed = false;

    public void TaskOnClick()
    {
        isPressed = !isPressed;
        print(isPressed);
        turretSpawn(isPressed);

    }


    void turretSpawn(bool x)
    {
        

            if (x == true || Input.GetButtonDown("Fire1"))
            {
            //  var mousePos = Input.mousePosition;
            //      // we want 2m away from the camera position

            var objectPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            var myObject = Instantiate(turretPrefab, objectPos, Quaternion.identity);

            //Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //if (Physics.Raycast(ray))
            //{

            //    Instantiate(turretPrefab, ray.direction, transform.rotation);
            //}

        }
        
    }

    
}
