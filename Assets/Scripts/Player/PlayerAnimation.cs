using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    public string facing = "Down";
    Animator anim;
    Rigidbody2D rb;
    bool facingRight = true;

    void Start()
    {
        anim = GetComponent<Animator>();    
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(rb.velocity == new Vector2(0,0))
        {
            anim.SetTrigger("Idle");
            anim.SetBool("MoveSide", false);
            anim.SetBool("MoveUp", false);
            anim.SetBool("MoveDown", false);
        } 
        else if(rb.velocity.y > 0 )
        {
            anim.SetBool("MoveUp", true);
            anim.SetBool("MoveDown", false);
            anim.SetBool("MoveSide", false);
            anim.SetBool("Idle", false);
            facing = "Up";
        } 
        else if(rb.velocity.y < 0 )
        {
            anim.SetBool("MoveDown", true);
            anim.SetBool("MoveSide", false);
            anim.SetBool("MoveUp", false);
            anim.SetBool("Idle", false);
            facing = "Down";
        }
        else if(rb.velocity.x < 0)
        {
            anim.SetBool("MoveSide", true);
            anim.SetBool("MoveUp", false);
            anim.SetBool("MoveDown", false);
            anim.SetBool("Idle", false);
            facing = "Side";
            if(facingRight)
            {
                transform.Rotate(0f,180f,0f);
                facingRight = !facingRight;
            }
        }
        else if(rb.velocity.x > 0)
        {
            anim.SetBool("MoveSide", true);
            anim.SetBool("MoveUp", false);
            anim.SetBool("MoveDown", false);
            anim.SetBool("Idle", false);
            facing = "Side";
            if(!facingRight)
            {
                transform.Rotate(0f, 180f, 0f);
                facingRight = !facingRight;
            }
        }
    }
}
