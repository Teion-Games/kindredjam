using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetCard : MonoBehaviour
{
    public int index;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player1" || other.gameObject.tag=="Player2")
        {
            PlayerGetCard(index);
        }
    }

    // Update is called once per frame
    public void PlayerGetCard(int cardIndex)
    {
        PlayerPrefs.SetInt("card"+cardIndex, 1);
        Destroy(gameObject);
    }
}
