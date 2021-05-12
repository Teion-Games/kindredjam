using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReloadScene : MonoBehaviour
{

    // Update is called once per frame
    void Reload()
    {
        foreach(SavePosition item in FindObjectsOfType<SavePosition>())
        {
            item.LoadPosition();
        }
        foreach(PlayerInput playerInp in FindObjectsOfType<PlayerInput>())
        {
            playerInp.enabled = true;
            playerInp.GetComponent<SpriteRenderer>().enabled= true;
            playerInp.GetComponent<Collider2D>().enabled = true;
            playerInp.GetComponent<PlayerAnimation>().enabled = true;
            playerInp.GetComponent<PlayerMovment>().enabled = true;
            playerInp.GetComponent<PlayerPower>().enabled = true;
        }
        FindObjectOfType<CheckpointMaster>().LoadCheckPoint(false);

        gameObject.SetActive(false);
    }
    
}
