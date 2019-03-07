using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class autoBaker : MonoBehaviour
{

    public NavMeshSurface[] surface;
    void Start()
    {
        bakeRuntime();
    }

   

    public void bakeRuntime()
    {
        for (int i = 0; i < surface.Length; i++)
        {
            surface[i].BuildNavMesh();
        }
    }


}
