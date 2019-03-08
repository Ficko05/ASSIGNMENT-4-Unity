using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dontBlockAgentTurner : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "turret")
        {
            Destroy(collision.gameObject);
        }
    }
}
