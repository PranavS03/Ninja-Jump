    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class BodyControl : MonoBehaviour
{
    private Rigidbody2D bd;
    private const float UP=15f;
    private const float direction=10f;
    private bool facingRight=true;
    public Animator anim;
    public GameObject GameOver;
    public GameObject NextWindow;

  
    
    private void Awake(){

        bd = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

   
    

     
   

    // Update is called once per frame
    void FixedUpdate()
    { 
        anim.SetBool("isRunning",false);
        anim.SetBool("isJumping",false);   
        if (Input.GetKey(KeyCode.UpArrow))
        {

            up();
            
            

         
            
            }
        
        else if (Input.GetKey(KeyCode.LeftArrow)){
            left();
            
            anim.SetBool("isRunning",true);
        } 
        else if(Input.GetKey(KeyCode.RightArrow)){
            right();
            
            anim.SetBool("isRunning",true);

            
        }


       
        
    }
    
    public void up(){
        bd.velocity = Vector2.up * UP;///jumping
        anim.SetBool("isJumping",true);
        SoundManager.playjump();
        
        
        }
    private void left(){
        bd.velocity = Vector2.left * direction;///moving left
        }
    private void right(){
        bd.velocity = Vector2.right * direction;///moving right
        }
    void OnCollisionStay2D(Collision2D col) {
        ///makes the character static on touching spikes
        if (col.gameObject.tag == "Ground"){
            anim.SetTrigger("dead");
            GameOver.SetActive(true);
            bd.bodyType=RigidbodyType2D.Static;}
        if (col.gameObject.tag == "door"){
            SoundManager.playvictory();
            NextWindow.SetActive(true);
            bd.bodyType=RigidbodyType2D.Static;}
        
    ///this is the function used to flip the game object
    }
    void Flip(){
        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
        }

}
 