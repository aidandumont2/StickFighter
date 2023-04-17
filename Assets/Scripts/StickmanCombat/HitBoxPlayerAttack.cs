using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBoxPlayerAttack : MonoBehaviour
{
    private PlayerManager refPlayerManager;
    private bool isEnnemyUnderAttack = false;
    public int damageAttackLegere = 5;
    public int damageAttackLourde = 10;

    // Update is called once per frame
    public void ActiveHitBox(string typeAttack)
    {
        if (isEnnemyUnderAttack == true)
        {
            Debug.Log("touché");
            if (typeAttack == "Legere")
            {
                refPlayerManager.lifepoint -= damageAttackLegere;
                //gameObject.GetComponent<PlayerManager>().stamina -= 1;
            }else if (typeAttack == "Lourde")
            {
                refPlayerManager.lifepoint -= damageAttackLourde;
                //gameObject.GetComponent<PlayerManager>().stamina -= 3;
            }

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       
        if (collision.gameObject.tag != "Camp") { 
            Debug.Log(collision.gameObject.GetComponentInParent<PlayerManager>());
            refPlayerManager = collision.gameObject.GetComponentInParent<PlayerManager>();
            isEnnemyUnderAttack = true;
        }
       
        //Debug.Log(refPlayerManager);
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag != "Camp") { 
            isEnnemyUnderAttack = false;
        }
        
        //Debug.Log(refPlayerManager);
    }
}
