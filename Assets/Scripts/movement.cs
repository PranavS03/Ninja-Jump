using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    private Rigidbody2D rb;
    private bool moveLeft;
    private bool moveRight;
    private float horizontalMove;
    public float speed = 10f;
    public Animator anim;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

        moveLeft = false;
        moveRight = false;
    }

    public void PointerDownLeft()
    {
        moveLeft = true;
        
    }

    public void PointerUpLeft()
    {
        moveLeft = false;
        
    }

    public void PointerDownRight()
    {
        moveRight = true;
       
        
    }

    public void PointerUpRight()
    {
        moveRight = false;
        
    }

    void Update()
    {
        MovementPlayer();
        
    }

    void MovementPlayer()
    {
        if (moveLeft)
        {
            horizontalMove = -speed;
            anim.SetBool("isRunning",true);
            
            
            


        }

        else if (moveRight)
        {
            horizontalMove = speed;
            anim.SetBool("isRunning",true);
            
            
        }

        else
        {
            horizontalMove = 0;
            

        }
    }
    

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontalMove, rb.velocity.y);
    }
}
