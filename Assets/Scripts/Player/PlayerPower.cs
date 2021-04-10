using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPower : MonoBehaviour
{

    public GameObject firstPower;
    public GameObject secondPower;
    public GameObject powerParticle;
    public ParticleSystem holdParticle;
    public Transform firstPowerDownPosition, firstPowerUpPosition, firstPowerLeftPosition, firstPowerRightPosition;
    GameObject powerGo;

    public void UsePower()
    {
        switch (GetComponent<PlayerAnimation>().facing)
        {
            case "Down":
                powerGo = Instantiate(firstPower, firstPowerDownPosition.position, Quaternion.identity);
                powerGo.transform.parent = transform;
                powerParticle.transform.position = firstPowerDownPosition.position;
                powerParticle.GetComponent<ParticleSystem>().Play();
                break;
            case "Up":
                powerGo = Instantiate(firstPower, firstPowerUpPosition.position, Quaternion.identity);
                powerGo.transform.parent = transform;
                powerParticle.transform.position = firstPowerUpPosition.position;
                powerParticle.GetComponent<ParticleSystem>().Play();
                break;
            case "Left":
                powerGo = Instantiate(firstPower, firstPowerLeftPosition.position, Quaternion.identity);
                powerGo.transform.parent = transform;
                powerParticle.transform.position = firstPowerLeftPosition.position;
                powerParticle.GetComponent<ParticleSystem>().Play();
                break;
            case "Right":
                powerGo = Instantiate(firstPower, firstPowerRightPosition.position, Quaternion.identity);
                powerGo.transform.parent = transform;
                powerParticle.transform.position = firstPowerRightPosition.position;
                powerParticle.GetComponent<ParticleSystem>().Play();
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
                powerParticle.transform.position = firstPowerDownPosition.position;
                powerParticle.GetComponent<ParticleSystem>().Play();
                break;
            case "Up":
                powerGo = Instantiate(secondPower, firstPowerUpPosition.position, Quaternion.identity);
                powerParticle.transform.position = firstPowerUpPosition.position;
                powerParticle.GetComponent<ParticleSystem>().Play();
                break;
            case "Left":
                powerGo = Instantiate(secondPower, firstPowerLeftPosition.position, Quaternion.identity);
                powerParticle.transform.position = firstPowerLeftPosition.position;
                powerParticle.GetComponent<ParticleSystem>().Play();
                break;
            case "Right":
                powerGo = Instantiate(secondPower, firstPowerRightPosition.position, Quaternion.identity);
                powerParticle.transform.position = firstPowerRightPosition.position;
                powerParticle.GetComponent<ParticleSystem>().Play();
                break;
        }
        GetComponent<PlayerAnimation>().AttackAnimation();
    }

    public void DestroyFirstPower()
    {
        Destroy(powerGo);
    }

    public void HoldParticlePlay()
    {
        holdParticle.Play();
    }

    public void HoldParticleStop()
    {
        holdParticle.Stop();
    }
}
