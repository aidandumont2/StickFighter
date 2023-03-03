using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttacks : MonoBehaviour
{
    public GameObject attackSpecial;

    public PlayerManager player;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && player.isCrouching == false && player.isGrounded == true && player.isMoving == false && player.isSpecialAtt == false && player.stamina >=2)
        {
            Instantiate(attackSpecial, transform.position + new Vector3(1,0,0), Quaternion.identity);
            player.stamina -= 2;
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
