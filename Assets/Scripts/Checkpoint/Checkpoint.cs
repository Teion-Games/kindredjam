using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public Vector2 p1SavePosition, p2SavePosition;
    public bool saveP1Pos, saveP2Pos;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag=="Player1" || other.gameObject.tag=="Player2")
        {
            if(saveP1Pos)
            {
                PlayerPrefs.SetFloat("p1Xpos", p1SavePosition.x);
                PlayerPrefs.SetFloat("p1Ypos", p1SavePosition.y);
            }
            if(saveP2Pos)
            {
                PlayerPrefs.SetFloat("p2Xpos", p2SavePosition.x);
                PlayerPrefs.SetFloat("p2Ypos", p2SavePosition.y);
            }
        }
    }
}
