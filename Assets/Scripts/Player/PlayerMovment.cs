using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    [SerializeField] float vel;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();    
    }

    
    void Update()
    {
        Move();
    }

    void Move()
    {
        rb.velocity = new Vector2(GetComponent<PlayerInput>().horizontalMove * vel , GetComponent<PlayerInput>().verticalMove * vel);
    }
}
