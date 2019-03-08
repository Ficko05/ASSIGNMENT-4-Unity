using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnAI : MonoBehaviour
{
    public Rigidbody prefab;
    public float spawnDelay = 10;
    public GameObject Spawnpoint;
    Rigidbody mob;
    private int nameNumber;

    public void TaskOnClick()
    {
        spawn();
    }

    void spawn()
    {
       mob = Instantiate(prefab, Spawnpoint.transform.position, Spawnpoint.transform.rotation);
        mob.name = "agentTuner" + nameNumber;
        nameNumber++;
    }
   
}
