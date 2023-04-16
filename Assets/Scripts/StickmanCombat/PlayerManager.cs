using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerManager : MonoBehaviour
{
    public string numPlayer;
    public TextMeshProUGUI refTMP;
    public string Camps = "";
    public bool isGrounded = true;
    public bool isCrouching = false;
    public bool isMoving = false;
    public bool isSpecialAtt = false;
    public bool isStatic = true;

    public float speed = 5f;
    public float jumpspeed = 2f;

    public int lifepoint = 100;
    public int stamina = 7;

    
    void Update()
    {
        if (lifepoint <= 0)
        {
            GameManager.FinCombat();
        }
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Camp1")
        {
            numPlayer = "Player1";
            gameObject.GetComponent<PlayerMovement>().ChoixInputCamp1();
        }else if(collision.gameObject.name == "Camp2")
        {
            numPlayer = "Player2";
            gameObject.GetComponent<PlayerMovement>().ChoixInputCamp2();
        }
        collision.gameObject.SetActive(false);
        refTMP.text = numPlayer;
    }
}
