using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueStarter : MonoBehaviour
{
    
    public Dialogue[] dialogue;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag=="Player1" || other.gameObject.tag=="Player2")
        {
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
        }
    }
}
