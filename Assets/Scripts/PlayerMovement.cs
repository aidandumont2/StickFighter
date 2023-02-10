using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float speed = 5f;
    private float jumpspeed = 2f;

    public Rigidbody2D rb;

    public SpriteRenderer spriterenderer;
    public Sprite spriteCrouch;
    public Sprite spriteStand;

    private bool isGrounded = true;
    private bool isCrouching = false;
    // Update is called once per frame
    void Update()
    {
        //IsGrounded();
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if(isCrouching == false)
            {
                Move(-speed);
            }
            
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            if (isCrouching == false)
            {
                Move(speed);
            }
            
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Crouch();
        }
        else if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            spriterenderer.sprite = spriteStand;
            isCrouching = false;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (isCrouching == false)
            {
                Jump();
            }
            
        }
    }


    private void Move(float speed)
    {
        transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
        //transform forward => new vector(0,0,1)

    }

    private void Crouch()
    {
        spriterenderer.sprite = spriteCrouch;
        isCrouching = true;
    }

    private void Jump()
    {
            if (isGrounded == true)
        {
            speed = jumpspeed;
            rb.AddForce(Vector2.up * 6.5f, (ForceMode2D)ForceMode2D.Impulse);
            isGrounded = false;

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
