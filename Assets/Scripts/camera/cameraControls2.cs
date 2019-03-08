using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraControls2 : MonoBehaviour
{

    public float speed = 20.0f;

    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            if (Input.GetAxis("Mouse X") > 0)
            {
                transform.position += new Vector3(Input.GetAxisRaw("Mouse X") * Time.deltaTime * speed,
                                                   0.0f, Input.GetAxisRaw("Mouse Y") * Time.deltaTime * speed);
            }

            else if (Input.GetAxis("Mouse X") < 0)
            {
                transform.position += new Vector3(Input.GetAxisRaw("Mouse X") * Time.deltaTime * speed,
                                                   0.0f, Input.GetAxisRaw("Mouse Y") * Time.deltaTime * speed);
            }
        }
    }
}
