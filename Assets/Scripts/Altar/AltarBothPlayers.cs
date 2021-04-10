using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class AltarBothPlayers : MonoBehaviour
{
    bool interactingP1, interactingP2;
    public Vector2 p1NextCheckPoint, p2NextCheckpoint;
    public GameObject waitingForP2, waitingForP1;
    public string nextSceneName;
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag=="Player1")
        {
            interactingP1 = true;
            waitingForP1.SetActive(false);
            if(interactingP2 == false)
            {
                waitingForP2.SetActive(true);
            }
        }

        if(other.gameObject.tag=="Player2")
        {
            interactingP2 = true;
            waitingForP2.SetActive(false);
            if(interactingP1 == false)
            {
                waitingForP1.SetActive(true);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(interactingP1 && interactingP2)
        {
            GoToNextPhase();
        }
    }


    void GoToNextPhase()
    {
        PlayerPrefs.SetFloat("p1Xpos", p1NextCheckPoint.x);
        PlayerPrefs.SetFloat("p1Ypos", p1NextCheckPoint.y);
        PlayerPrefs.SetFloat("p2Xpos", p2NextCheckpoint.x);
        PlayerPrefs.SetFloat("p2Ypos", p2NextCheckpoint.y);
        SceneManager.LoadScene(nextSceneName);
    }
}
