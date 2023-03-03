using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    /*private float speed = 5f;
    private float jumpspeed = 2f;*/
    public PlayerManager player;

    public Rigidbody2D rb;

    public SpriteRenderer spriterenderer;
    public Sprite spriteCrouch;
    public Sprite spriteStand;

    /*private bool isGrounded = true;
    private bool isCrouching = false;*/
    // Update is called once per frame
    void Update()
    {
        //IsGrounded();
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if(player.isCrouching == false)
            {
                player.isMoving = true;
                Move(-player.speed);
            }
            
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            if (player.isCrouching == false)
            {
                player.isMoving = true;
                Move(player.speed);
            }
            
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Crouch();
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
                Jump();
            }
            
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

    }

    private void Crouch()
    {
        if(player.isGrounded == true)
        {
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
            player.isGrounded = false;

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
