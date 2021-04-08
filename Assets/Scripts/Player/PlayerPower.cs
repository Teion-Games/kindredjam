using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPower : MonoBehaviour
{

    public GameObject firstPower;
    public GameObject secondPower;

    public void UsePower()
    {
        Instantiate(firstPower, transform.position, Quaternion.identity);
    }

    public void UseSecundaryPower()
    {
        Instantiate(secondPower, transform.position, Quaternion.identity);
    }
}
