using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public SpriteRenderer spriterenderer;
    public Sprite spriteCrouch;
    public Sprite spriteStand;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Move(-speed);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            Move(speed);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Crouch();
        }
        else if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            spriterenderer.sprite = spriteStand;
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            Move(speed);
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
    }
}
