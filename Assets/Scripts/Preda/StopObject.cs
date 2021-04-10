using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopObject : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Player1" || other.gameObject.tag == "Player2")
        {
            GetComponent<Rigidbody2D>().isKinematic = true;
        }
    }
    void OnCollisionExit2D(Collision2D other)
    {
        if(other.gameObject.tag == "Player1" || other.gameObject.tag == "Player2")
        {
            GetComponent<Rigidbody2D>().isKinematic = false;
        }
    }
}
