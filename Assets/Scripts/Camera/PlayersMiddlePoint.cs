using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayersMiddlePoint : MonoBehaviour
{
    public Transform player1, player2;

    void Update()
    {
        transform.position = new Vector2((player1.position.x+player2.position.x)/2, (player1.position.y+player2.position.y)/2);
    }
}
