using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitSphere : MonoBehaviour
{

    public float radius = 5;
    //public spawnAI script;
    public float cooldownTimer = 2f;
    bool cooldown = false;
    public float resetTimer = 2f;
    void Update()
    {
        Collider[] hits = Physics.OverlapSphere(transform.position, radius);
        if (cooldown == false)
        {
            foreach (Collider hit in hits)
            {
                if (hit.tag == "mob")
                {
                    if (cooldown == false)
                    {
                        cooldown = true;
                        cooldownTimer = resetTimer;
                        if (hit.transform.gameObject.GetComponent<healthScript>().reduceHealth())
                        {
                            Destroy(hit.gameObject);
                        }
                    }
                }
            }
        }

        if (cooldown == true)
        {
            cooldownTimer = cooldownTimer - Time.deltaTime;
            if (cooldownTimer <= 0)
            {
                cooldown = false;
            }
        }
    }

}
