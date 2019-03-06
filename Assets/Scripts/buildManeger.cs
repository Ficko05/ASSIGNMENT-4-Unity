using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buildManeger : MonoBehaviour
{

    public static buildManeger instance;

    void Awake()
    {
        instance = this;
    }

    public GameObject turretprefab;

    void Start()
    {
        turretToBuild = turretprefab;
    }

    private GameObject turretToBuild;

    public GameObject GetTurretToBuild()
    {
        return turretToBuild;
    }




}
