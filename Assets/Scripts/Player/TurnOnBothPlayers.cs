using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOnBothPlayers : MonoBehaviour
{
    
    public void TurnOnControllers()
    {
        foreach (PlayerInput playerInput in FindObjectsOfType<PlayerInput>())
        {
            playerInput.EnableControls();
        }
        
    }
}
