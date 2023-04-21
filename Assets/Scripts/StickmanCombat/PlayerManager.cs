using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    public Slider lifeBar;
    public Slider staminaBar;
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

    private float tempsRegenStamina = 2.00f;
    
    void Update()
    {
        RegenStamina();
        lifeBar.value = lifepoint;
        staminaBar.value = stamina;
        if (lifepoint <= 0)
        {
            GameManager.FinCombat();
        }
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Camp1")
        {
            collision.gameObject.SetActive(false);
            numPlayer = "Player1";
            gameObject.GetComponent<PlayerMovement>().ChoixInputCamp1();

        }
        else if(collision.gameObject.name == "Camp2")
        {
            collision.gameObject.SetActive(false);
            numPlayer = "Player2";
            gameObject.GetComponent<PlayerMovement>().ChoixInputCamp2();
        }
        
        refTMP.text = numPlayer;
    }

    private void RegenStamina()
    {
        if (stamina != 7)
        {
            tempsRegenStamina -= Time.deltaTime;
            if(tempsRegenStamina <= 0.00f)
            {
               stamina += 1;
               tempsRegenStamina = 1.20f;
            }
        }
        
    }
}
