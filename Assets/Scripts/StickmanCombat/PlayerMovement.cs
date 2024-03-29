using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Animator anim;
    
    /*private float speed = 5f;
    private float jumpspeed = 2f;*/
    public HitBoxPlayerAttack refHitBoxAttack;

    public PlayerManager player;

    public BoxCollider2D hitBoxAttack;

    public Rigidbody2D rb;

    public SpriteRenderer spriterenderer;
    public Sprite spriteCrouch;
    public Sprite spriteStand;

    private KeyCode saut;
    private KeyCode avancer;
    private KeyCode reculer;
    public KeyCode attSpe;
    private KeyCode attLeg;
    private KeyCode attLour;

    void Start()
    {
        
        anim = gameObject.GetComponent<Animator>();
        //Définir ou est le joueur : Camp1 ou Camp2
    }
    void Update()
    {
        anim.SetBool("Static", player.isStatic);
        anim.SetBool("Sol", player.isGrounded);
        if (Input.GetKey(reculer))
        {
            if (player.isCrouching == false)
            {
                player.isMoving = true;
                anim.SetBool("Static", false);
                anim.SetBool("MarcheArriere", true);
                Move(-player.speed);
            }

        }
        else if (Input.GetKey(avancer))
        {
            if (player.isCrouching == false)
            {
                player.isMoving = true;
                
                anim.SetBool("Static", false);
                anim.SetBool("MarcheAvant", true);
                Move(player.speed);
            }

        }
        else if (Input.GetKeyDown(KeyCode.AltGr))
        {
            Crouch();
        }
        else if (Input.GetKeyUp(KeyCode.AltGr))
        {
            spriterenderer.sprite = spriteStand;
            player.isCrouching = false;
        }
        else if (Input.GetKeyUp(attLeg) && player.isGrounded == true)
        {
            if (!anim.GetCurrentAnimatorStateInfo(0).IsName("AttaqueLégère") && player.stamina >= 1)
            {//anim.GetComponent<Animation>().IsPlaying("AttaqueLégère")
                player.stamina -= 1;
                anim.Play("AttaqueLégère");
                refHitBoxAttack.ActiveHitBox("Legere");
            }
            
            //new WaitForSeconds((float)0.42);

        }
        else if (Input.GetKeyUp(attLour) && player.isGrounded == true)
        {
            if (!anim.GetCurrentAnimatorStateInfo(0).IsName("AttaqueLourde") && player.stamina >= 3)
            {
                player.stamina -= 3;
                anim.Play("AttaqueLourde");
                refHitBoxAttack.ActiveHitBox("Lourde");
            }
            
            //new WaitForSeconds((float)1.03);
            
        }
        if (Input.GetKeyDown(saut))
        {
            if (player.isCrouching == false)
            {
                Jump();
            }

        }
        if (Input.GetKeyUp(avancer) || Input.GetKeyUp(reculer))
        {
            player.isStatic = true;
            player.isCrouching = false;
            player.isMoving = false;
            anim.SetBool("MarcheArriere", false);
            anim.SetBool("MarcheAvant", false);

        }
    }


    private void Move(float speed)
    {
        transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
        //transform forward => new vector(0,0,1)

    }

    private void Crouch()
    {
        if (player.isGrounded == true)
        {
            spriterenderer.sprite = spriteCrouch;
            player.isCrouching = true;

        }

    }

    private void Jump()
    {
        if (player.isGrounded == true)
        {
            if (!anim.GetCurrentAnimatorStateInfo(0).IsName("Saut"))
            {
                anim.Play("Saut");
                player.speed = player.jumpspeed;
                rb.AddForce(Vector2.up * 6.5f, (ForceMode2D)ForceMode2D.Impulse);
                player.isGrounded = false;
            }
                
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
        //Debug.Log(collision.gameObject.name);
        //Debug.Log("ground test");
        if (collision.gameObject.name == "Sol")
        {
            player.isGrounded = true;
            player.speed = 5f;
        }
    }

    public void ChoixInputCamp1()
    {
        
        saut = KeyCode.Z;
        avancer = KeyCode.D;
        reculer = KeyCode.Q;
        attLeg = KeyCode.E;
        attLour = KeyCode.A;
        attSpe = KeyCode.R;
    }

    public void ChoixInputCamp2()
    {
        
        saut = KeyCode.UpArrow;
        avancer = KeyCode.RightArrow;
        reculer = KeyCode.LeftArrow;
        attLeg = KeyCode.K;
        attLour = KeyCode.J;
        attSpe = KeyCode.L;
    }
}
