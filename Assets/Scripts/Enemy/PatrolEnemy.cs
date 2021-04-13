using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolEnemy : MonoBehaviour
{
    public float movementRange;
    public bool horizontalMove;
    public float speed;
    public float stopTime;

    Rigidbody2D rb;
    float distanceMoved;
    Vector2 initialPosition;
    float direction =1;
    bool stopped;
    float stopTimeSave;
    bool canChangeDirections = true;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        initialPosition = transform.position;
        stopTimeSave = stopTime;
    }

    
    void Update()
    {
        if(stopped)
        {
            CountTimeToStartMovingAgain();
        }

        if(horizontalMove && !stopped)
        {
            MoveHorizontal();
        }
        else if (!horizontalMove && !stopped)
        {
            MoveVertical();   
        }

        CheckDirection();
        CalculateDistanceMoved();
    }


    void MoveHorizontal()
    {
        rb.velocity = new Vector2(direction*speed, 0);
    }

    void MoveVertical()
    {
        rb.velocity = new Vector2(0, direction*speed);
    }
    
    void CheckDirection()
    {
        if(distanceMoved>=movementRange && canChangeDirections)
        {
            StopPlayer();
            direction *= -1;
            canChangeDirections = false;
        }
    }

     void CalculateDistanceMoved()
    {
        distanceMoved = Vector2.Distance(transform.position, initialPosition);
    }


    void StopPlayer()
    {
        rb.velocity = new Vector2(0f,0f);
        stopped = true;
    }

    void CountTimeToStartMovingAgain()
    {
        if(stopTime<=0)
        {
            stopped = false;
            stopTime = stopTimeSave;
            Invoke("ResetCanChangeDirections", 0.5f);
        }
        else
        {
            stopTime -= Time.deltaTime;
        }
    }

    void ResetCanChangeDirections()
    {
        canChangeDirections = true;
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(transform.position, movementRange);
    }
}
