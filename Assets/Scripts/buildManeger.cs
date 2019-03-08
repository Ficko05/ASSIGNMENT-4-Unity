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

    public GameObject standertTurretprefab;

    public GameObject fireTurretprefab;
    

    private GameObject turretToBuild;


    public GameObject GetTurretToBuild()
    {
        return turretToBuild;
    }

    public void setTurretToBuild(GameObject turret)
    {
        turretToBuild = turret;
    }




}
