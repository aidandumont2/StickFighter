using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    /*private float speed = 5f;
    private float jumpspeed = 2f;*/
    public PlayerManager player;

    public Rigidbody2D rb;
    Animator anim;

    public SpriteRenderer spriterenderer;
    public Sprite spriteCrouch;
    public Sprite spriteStand;
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        anim.SetBool("Static",isStatic);
        anim.SetBool("Sol", isGrounded);
        if (Input.GetKey(KeyCode.LeftArrow))
        {

            
            if(player.isCrouching == false)
            {
                player.isMoving = true;
                anim.SetBool("MarcheAvant", false);
                anim.SetBool("Static", false);
                anim.SetBool("MarcheArriere", true);
                Move(-player.speed);
            }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (player.isCrouching == false)
            {
                if (isGrounded == true){
                    anim.SetBool("Static", false);
                    anim.SetBool("MarcheAvant", true);                
                    player.isMoving = true;
                    Move(player.speed);
                }
            }

        }if (Input.GetKey(KeyCode.DownArrow))
        {
            if (isGrounded == true)
                isCrouching = true;
                Crouch();
            Debug.Log(isStatic);
        }
        else if (Input.GetKeyUp(KeyCode.E)) {
            if (isGrounded == false)
            {
                
                //Debug.Log(isAttack);
            }
            else {
                anim.Play("AttaqueL�g�re"); 
            }
        else if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            spriterenderer.sprite = spriteStand;
            player.isCrouching = false;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (player.isCrouching == false)
            {
                
                //anim.SetBool("Saut", true);
                anim.SetBool("Static", false);
                isCrouching = false;
                Jump();
                isGrounded = false;
                //if (Input.GetKeyUp(KeyCode.Space))
                //{
                    //anim.SetBool("AttaqueL�g�re", true);
                    //anim.Play("SautAttaque");
                //}

            }

        } if (Input.GetKeyDown(KeyCode.A)) {
            anim.Play("AttaqueLourde");
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow))
        {
            player.isMoving = false;
        }
    }


    private void Move(float speed)
    {
        transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
        //transform forward => new vector(0,0,1)
        isStatic = false;

    }

    private void Crouch()            
    {
        if(player.isGrounded == true)
        {
            anim.SetBool("Accroupie", isCrouching);
            anim.SetBool("Static", isStatic);
            spriterenderer.sprite = spriteCrouch;
            player.isCrouching = true;

        }
        
    }

    private void Jump()
    {
            if (player.isGrounded == true)
        {
            player.speed = player.jumpspeed;
            rb.AddForce(Vector2.up * 6.5f, (ForceMode2D)ForceMode2D.Impulse);
            anim.Play("Saut");
            if (Input.GetKeyUp(KeyCode.Space) && Input.GetKeyUp(KeyCode.LeftArrow))
            {
                anim.Play("SautAttaque");
            }
                player.isGrounded = false;
            player.isStatic= false;

        }
            
    }

    /*private void IsGrounded() {
        Debug.Log("ground test");
        if (Collision2D )
        {
            Debug.Log("is grounded true");
            isGrounded = true;
        }
        else
        {
            Debug.Log("ground false");
            isGrounded = false;
        }
    }*/

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("ground test");
        if (collision.gameObject.name == "Sol")
        {
            player.isGrounded = true;
            player.speed = 5f;
        }
        
    }
}
