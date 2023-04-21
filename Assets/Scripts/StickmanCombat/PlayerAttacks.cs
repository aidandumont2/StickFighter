using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttacks : MonoBehaviour
{
    public PlayerMovement playermovement;
    public GameObject attackSpecial;
    Animator anim;
    public PlayerManager player;

    private float pointLancementAttSpe = 2.5f;
    private void Start()
    {
        anim = GetComponent<Animator>(); 
        if(player.numPlayer == "Player2")
        {
            pointLancementAttSpe = -2.5f;
        }
    }

    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(playermovement.attSpe) && player.isCrouching == false && player.isGrounded == true && player.isMoving == false && player.isSpecialAtt == false && player.stamina >=5)
        {
            anim.Play("LancerBatarang");
            Instantiate(attackSpecial, transform.position + new Vector3(pointLancementAttSpe,0,0), Quaternion.identity);
            player.stamina -= 5;
            player.isSpecialAtt = true;
            StartCoroutine(DelaySpeAttack());
            
        }
    }

    IEnumerator DelaySpeAttack()
    {
        yield return new WaitForSeconds(1);
        player.isSpecialAtt = false;
    }
}
