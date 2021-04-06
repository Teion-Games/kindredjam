using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPower : MonoBehaviour
{
    public List<string> powerList= new List<string>();
    public GameObject darkHole;
    int activePower = 0 ;

    public void UsePower()
    {
        switch (powerList[activePower])
        {
            case "first":
                Instantiate(darkHole, transform.position, Quaternion.identity);
                break;
            case "fire":
                Debug.Log("Firepower");
                break;
            case "water":
                Debug.Log("waterpower");
                break;
        }        
    }

    public void CiclePowersUp()
    {
        activePower++;
        if(activePower>powerList.Count-1)
        {
            activePower = 0;
        }
    }

    public void CiclePowersDown()
    {
        activePower--;
        if(activePower < 0)
        {
            activePower = powerList.Count-1;
        }
    }
}
