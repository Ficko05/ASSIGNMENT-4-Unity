using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;

public class nodeScript : MonoBehaviour
{
    public Color hoverColor;

    private GameObject turret;
    public Vector3 offset;

    private Renderer rend;

    private Color startColor;

    buildManeger buildManeger;

    void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;

        buildManeger = buildManeger.instance;

    }
   

    void OnMouseDown()
    {
        if (EventSystem.current.IsPointerOverGameObject())
        {
            return;
        }
        if (buildManeger.GetTurretToBuild() == null)
        {
            return;
        }
        
        if (turret != null)
        {
            Debug.Log("cant build there");
            //TODO display on screen
        }

        GameObject turretToBuild = buildManeger.instance.GetTurretToBuild();
        turret = (GameObject)Instantiate(turretToBuild, transform.position + offset, transform.rotation);

        

    }

    void OnMouseEnter()
    {

        if (EventSystem.current.IsPointerOverGameObject())
        {
            return;
        }
        if (buildManeger.GetTurretToBuild() == null)
            return;

        rend.material.color = hoverColor;
        //print("im in here");
    }

    void OnMouseExit()
    {
        rend.material.color = startColor;
    }

}
