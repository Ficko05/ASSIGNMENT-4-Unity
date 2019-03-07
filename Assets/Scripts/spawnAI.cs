using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnAI : MonoBehaviour
{
    public Rigidbody prefab;
    public float spawnDelay = 10;
    public GameObject Spawnpoint;


    public void TaskOnClick()
    {
        spawn();
    }

    void spawn()
    {
        Instantiate(prefab, Spawnpoint.transform.position, Spawnpoint.transform.rotation);
    }

}
