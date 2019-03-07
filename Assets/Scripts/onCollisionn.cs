using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onCollisionn : MonoBehaviour
{
    public healthCounter healthScript;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "mob")
        {
            Destroy(collision.gameObject);
            healthScript.setCount();
            
         }
    }
}
