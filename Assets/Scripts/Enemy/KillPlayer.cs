using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillPlayer : MonoBehaviour
{
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag=="Player1" || other.gameObject.tag=="Player2")
        {
            KillThePlayer();
        }
    }

    public void KillThePlayer()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
