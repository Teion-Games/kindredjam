using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class BothPlayerDialogTrigger : MonoBehaviour
{
    bool interactingP1, interactingP2;
    public Dialogue[] dialogue;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag=="Player1")
        {
            interactingP1 = true;
        }

        if(other.gameObject.tag=="Player2")
        {
            interactingP2 = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.tag=="Player1")
        {
            interactingP1 = false;
        }

        if(other.gameObject.tag=="Player2")
        {
            interactingP1 = false;
        }
    }

    void Update()
    {
        if(interactingP1 && interactingP2)
        {
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
            Destroy(gameObject);
        }
    }
}

