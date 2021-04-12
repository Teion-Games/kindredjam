using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointMaster : MonoBehaviour
{

    public bool resetGame;
    void Start()
    {
        if(resetGame)
        {
            PlayerPrefs.SetFloat("p1Xpos", 0);
            PlayerPrefs.SetFloat("p1Ypos", 0);
            PlayerPrefs.SetFloat("p2Xpos", 0);
            PlayerPrefs.SetFloat("p2Ypos", 0);
        }
        if(PlayerPrefs.GetFloat("p1Xpos")!=0 && PlayerPrefs.GetFloat("p1Ypos")!=0)
        {
            PlayerInput[] players = FindObjectsOfType<PlayerInput>();
            foreach (PlayerInput player in players)
            {
                if(player.gameObject.name == "Ein")
                {
                    player.transform.position = new Vector2(PlayerPrefs.GetFloat("p1Xpos"), PlayerPrefs.GetFloat("p1Ypos"));
                }
            }
        }
        if(PlayerPrefs.GetFloat("p2Xpos")!=0 && PlayerPrefs.GetFloat("p2Ypos")!=0)
        {
            PlayerInput[] players = FindObjectsOfType<PlayerInput>();
            foreach (PlayerInput player in players)
            {
                if(player.gameObject.name == "Haw")
                {
                    player.transform.position = new Vector2(PlayerPrefs.GetFloat("p2Xpos"), PlayerPrefs.GetFloat("p2Ypos"));
                }
            }
        }
    }

}
