using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPower : MonoBehaviour
{

    public GameObject firstPower;
    public GameObject secondPower;
    public Transform firstPowerDownPosition, firstPowerUpPosition, firstPowerLeftPosition, firstPowerRightPosition;
    public void UsePower()
    {
        switch (GetComponent<PlayerAnimation>().facing)
        {
            case "Down":
                Instantiate(firstPower, firstPowerDownPosition.position, Quaternion.identity);
                break;
            case "Up":
                Instantiate(firstPower, firstPowerUpPosition.position, Quaternion.identity);
                break;
            case "Left":
                Instantiate(firstPower, firstPowerLeftPosition.position, Quaternion.identity);
                break;
            case "Right":
                Instantiate(firstPower, firstPowerRightPosition.position, Quaternion.identity);
                break;
        }
    }

    public void UseSecundaryPower()
    {
        Instantiate(secondPower, transform.position, Quaternion.identity);
    }
}
