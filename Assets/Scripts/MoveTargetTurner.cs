﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveTargetTurner : MonoBehaviour
{
    public NavMeshAgent agent;

    public GameObject goalDistance ;


    private void Start()
    {

        Vector3 target = goalDistance.gameObject.transform.position;
        agent.SetDestination(target);

    }
}
