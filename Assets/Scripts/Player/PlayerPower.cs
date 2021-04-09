using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPower : MonoBehaviour
{

    public GameObject firstPower;
    public GameObject secondPower;
    public Transform firstPowerDownPosition, firstPowerUpPosition, firstPowerSidePosition;
    GameObject powerGo;

    public void UsePower()
    {
        switch (GetComponent<PlayerAnimation>().facing)
        {
            case "Down":
                powerGo = Instantiate(firstPower, firstPowerDownPosition.position, Quaternion.identity);
                powerGo.transform.parent = transform;
                break;
            case "Up":
                powerGo = Instantiate(firstPower, firstPowerUpPosition.position, Quaternion.identity);
                powerGo.transform.parent = transform;
                break;
            case "Side":
                powerGo = Instantiate(firstPower, firstPowerSidePosition.position, Quaternion.identity);
                powerGo.transform.parent = transform;
                break;
        }
    }

    public void UseSecundaryPower()
    {
        Instantiate(secondPower, transform.position, Quaternion.identity);
    }

    public void DestroyFirstPower()
    {
        Destroy(powerGo);
    }
}
