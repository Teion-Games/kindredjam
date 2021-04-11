using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class AltarCollision : MonoBehaviour
{
    public GameObject particle;
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag=="Player1")
        {
            FindObjectOfType<AltarBrain>().interactingP1 = true;
            particle.GetComponent<ParticleSystem>().Play();
        }

        if(other.gameObject.tag=="Player2")
        {
            FindObjectOfType<AltarBrain>().interactingP2 = true;
            particle.GetComponent<ParticleSystem>().Play();
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.tag=="Player1")
        {
            FindObjectOfType<AltarBrain>().interactingP1 = false;
            particle.GetComponent<ParticleSystem>().Stop();
        }

        if(other.gameObject.tag=="Player2")
        {
            FindObjectOfType<AltarBrain>().interactingP1 = false;
            particle.GetComponent<ParticleSystem>().Stop();
        }
    }
}
