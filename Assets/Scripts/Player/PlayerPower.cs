using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPower : MonoBehaviour
{

    public GameObject firstPower;
    public GameObject secondPower;
    public Transform firstPowerDownPosition, firstPowerUpPosition, firstPowerLeftPosition, firstPowerRightPosition;
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
            case "Left":
                powerGo = Instantiate(firstPower, firstPowerLeftPosition.position, Quaternion.identity);
                powerGo.transform.parent = transform;
                break;
            case "Right":
                powerGo = Instantiate(firstPower, firstPowerRightPosition.position, Quaternion.identity);
                powerGo.transform.parent = transform;
                break;
        }

        GetComponent<PlayerAnimation>().AttackAnimation();
    }

    public void UseSecundaryPower()
    {
        switch (GetComponent<PlayerAnimation>().facing)
        {
            case "Down":
                powerGo = Instantiate(secondPower, firstPowerDownPosition.position, Quaternion.identity);
                powerGo.transform.parent = transform;
                break;
            case "Up":
                powerGo = Instantiate(secondPower, firstPowerUpPosition.position, Quaternion.identity);
                powerGo.transform.parent = transform;
                break;
            case "Left":
                powerGo = Instantiate(secondPower, firstPowerLeftPosition.position, Quaternion.identity);
                powerGo.transform.parent = transform;
                break;
            case "Right":
                powerGo = Instantiate(secondPower, firstPowerRightPosition.position, Quaternion.identity);
                powerGo.transform.parent = transform;
                break;
        }
        GetComponent<PlayerAnimation>().AttackAnimation();
    }

    public void DestroyFirstPower()
    {
        Destroy(powerGo);
    }
}
