using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DumbPlayer : MonoBehaviour
{
    
    public GameObject einTipGo, hawTipGo;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player1")
        {
            einTipGo.SetActive(true);
        } 
        else if(other.gameObject.tag == "Player2")
        {
            hawTipGo.SetActive(true);
        }


    }

    void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player1")
        {
            einTipGo.SetActive(false);
        } else if(other.gameObject.tag == "Player2")
        {
            hawTipGo.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
