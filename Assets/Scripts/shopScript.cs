using UnityEngine;

public class shopScript : MonoBehaviour
{
    buildManeger buildManeger;

    void Start()
    {
        buildManeger = buildManeger.instance;
    }

    public void standertTurret()
    {
        print("standert Turret");
        buildManeger.setTurretToBuild(buildManeger.standertTurretprefab);
    }
    public void fireTurret()
    {
        print("fire Turret");
        buildManeger.setTurretToBuild(buildManeger.fireTurretprefab);
    }
}
