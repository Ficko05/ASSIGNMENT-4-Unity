using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nodeScript : MonoBehaviour
{
    public Color hoverColor;

    private GameObject turret;
    public Vector3 offset;
    

    private Renderer rend;

    private Color startColor;

    void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;

    }

    void OnMouseDown()
    {
        if(turret != null)
        {
            Debug.Log("cant build there");
            //TODO display on screen
        }

        GameObject turretToBuild = buildManeger.instance.GetTurretToBuild();
        turret = (GameObject)Instantiate(turretToBuild, transform.position + offset, transform.rotation);

    }

    void OnMouseEnter()
    {
        rend.material.color = hoverColor;
        print("im in here");
    }

    void OnMouseExit()
    {
        rend.material.color = startColor;
    }

}
