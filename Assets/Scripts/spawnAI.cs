using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnAI : MonoBehaviour
{
    public Rigidbody prefab;
    public float spawnDelay = 10;
    public GameObject Spawnpoint;
    public bool firstSpawn = false;

   
    public void TaskOnClick()
    { 
        spawn();
    }

    void spawn()
    {
      if (firstSpawn == true)
        {
            Instantiate(prefab, Spawnpoint.transform.position, Spawnpoint.transform.rotation);
        }
        else
        {
            prefab.gameObject.SetActive(true);
            firstSpawn = true;
        }
    }

}
