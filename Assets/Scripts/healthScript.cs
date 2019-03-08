using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthScript : MonoBehaviour
{
    public int health = 5;
    public bool reduceHealth()
    {
        health = health - 1;
        print(health);
        if (health <= 0)
        {
            print("destroyed!");
            return true;

        }
        return false;
    }
}
