using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class AltarBrain : MonoBehaviour
{
    public bool interactingP1, interactingP2;
    public Vector2 p1NextCheckPoint, p2NextCheckpoint;
    public GameObject waitingForP2, waitingForP1;
    public string nextSceneName;
    
    // Update is called once per frame
    void Update()
    {
        if(interactingP1 && interactingP2)
        {
            waitingForP1.SetActive(false);
            waitingForP2.SetActive(false);
            GoToNextPhase();
        } 
        else if(interactingP1 && !interactingP2)
        {
            waitingForP1.SetActive(false);
            waitingForP2.SetActive(true);
        }
        else if(!interactingP1 && interactingP2)
        {
            waitingForP1.SetActive(true);
            waitingForP2.SetActive(false);
        }
        else if(!interactingP1 && !interactingP2)
        {
            waitingForP1.SetActive(false);
            waitingForP2.SetActive(false);
        }
    }


    void GoToNextPhase()
    {
        PlayerPrefs.SetFloat("p1Xpos", p1NextCheckPoint.x);
        PlayerPrefs.SetFloat("p1Ypos", p1NextCheckPoint.y);
        PlayerPrefs.SetFloat("p2Xpos", p2NextCheckpoint.x);
        PlayerPrefs.SetFloat("p2Ypos", p2NextCheckpoint.y);
        GameMaster.instance.fadeScreen.SetActive(true);
    }
}
