using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float speed = 5f;
    private float jumpspeed = 2f;
    

    public Rigidbody2D rb;
    Animator anim;

    public SpriteRenderer spriterenderer;
    public Sprite spriteCrouch;
    public Sprite spriteStand;

    private bool isGrounded = true;
    private bool isCrouching = false;
    private bool isStatic = false;
    private bool IsCrouch = false;
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        anim.SetBool("Static",isStatic);
        anim.SetBool("Sol", isGrounded);
        //IsGrounded();
        if (Input.GetKey(KeyCode.LeftArrow))
        {

            if (isCrouching == false)
            {
                anim.SetBool("MarcheAvant", true);
                anim.SetBool("Static", false);
                Move(-speed);
            }

        } else if (Input.GetKey(KeyCode.RightArrow))
        {
            if (isCrouching == false)
            {
                if (isGrounded == true)
                    anim.SetBool("MarcheAvant", true);
                anim.SetBool("Static", false);
                Move(speed);
            }

        } else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
           Crouch();
            isCrouching = true;
            anim.SetBool("Accroupie", isCrouching);        
        }
        else if (Input.GetKeyUp(KeyCode.Space)) {
            if (isGrounded == false)
            {
                
                //Debug.Log(isAttack);
            }
            else {
                anim.Play("AttaqueLégère"); 
            }
        }
        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            spriterenderer.sprite = spriteStand;
            isCrouching = false;
        } 
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (isCrouching == false)
            {
                
                //anim.SetBool("Saut", true);
                anim.SetBool("Static", false);
                isCrouching = false;
                Jump();
                isGrounded = false;
                //if (Input.GetKeyUp(KeyCode.Space))
                //{
                    //anim.SetBool("AttaqueLégère", true);
                    //anim.Play("SautAttaque");
                //}

            }

        } else if (Input.GetKeyDown(KeyCode.A)) {
            anim.Play("AttaqueLourde");
        }
        else
        {
            isStatic = true;
            isCrouching = false;
            anim.SetBool("MarcheAvant", false);

            
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
        spriterenderer.sprite = spriteCrouch;
        anim.SetBool("Accroupie", true);
        isCrouching = true;
        isStatic = false;
    }

    private void Jump()
    {
            if (isGrounded == true)
        {
            speed = jumpspeed;
            rb.AddForce(Vector2.up * 6.5f, (ForceMode2D)ForceMode2D.Impulse);
            anim.Play("Saut");
            if (Input.GetKeyUp(KeyCode.Space) && Input.GetKeyUp(KeyCode.LeftArrow))
            {
                anim.Play("SautAttaque");
            }
                isGrounded = false;
            isStatic= false;

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
            isGrounded = true;
            speed = 5f;
        }
        
    }
}
