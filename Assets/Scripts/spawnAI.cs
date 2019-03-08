using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnAI : MonoBehaviour
{
    public Rigidbody prefab;
    public float spawnDelay = 1;
    public GameObject Spawnpoint;
    Rigidbody mob;
    private int nameNumber;
    public int numberOfUnits = 5;

    public void TaskOnClick()
    {
        StartCoroutine("spawn");
        
    }

    IEnumerator spawn()
    {
        for (int i = 0; i < numberOfUnits; i++)
        {
            mob = Instantiate(prefab, Spawnpoint.transform.position, Spawnpoint.transform.rotation);
            mob.name = "agentTuner" + nameNumber;
            nameNumber++;   
            yield return new WaitForSeconds(spawnDelay);
        }
        numberOfUnits++;
    }
   
}
