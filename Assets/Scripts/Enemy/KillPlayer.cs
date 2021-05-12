using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillPlayer : MonoBehaviour
{
    
    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag=="Player1" || other.gameObject.tag=="Player2")
        {
            KillThePlayer(other.gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag=="Player1" || other.gameObject.tag=="Player2")
        {
            KillThePlayer(other.gameObject);
        }
    }

    public void KillThePlayer(GameObject player)
    {
        StartCoroutine(Kill(player));
    }

    IEnumerator Kill(GameObject player)
    {
        GameObject particle = player.transform.Find("Dying").gameObject;
        particle.GetComponent<ParticleSystem>().Play();
        player.GetComponent<SpriteRenderer>().enabled = false;
        player.GetComponent<PlayerInput>().enabled = false;
        player.GetComponent<Collider2D>().enabled = false;
        player.GetComponent<PlayerAnimation>().enabled = false;
        player.GetComponent<PlayerMovment>().enabled = false;
        player.GetComponent<PlayerPower>().enabled = false;
        yield return new WaitForSeconds(0.5f);
        GameMaster.instance.fadeDeathScreen.SetActive(true);
    }
}
