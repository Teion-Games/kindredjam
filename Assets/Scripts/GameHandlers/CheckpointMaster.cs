using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointMaster : MonoBehaviour
{

    void Start()
    {
        PlayerInput[] players = FindObjectsOfType<PlayerInput>();
        foreach (PlayerInput player in players)
        {
            if(player.gameObject.name == "Ein")
            {
                player.transform.position = new Vector2(PlayerPrefs.GetFloat("p1Xpos"), PlayerPrefs.GetFloat("p1Ypos"));
            }
            else
            {
                player.transform.position = new Vector2(PlayerPrefs.GetFloat("p2Xpos"), PlayerPrefs.GetFloat("p2Ypos"));
            }
        }
    }

}
