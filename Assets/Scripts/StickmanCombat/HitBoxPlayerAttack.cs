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
            }else if (typeAttack == "Lourde")
            {
                refPlayerManager.lifepoint -= damageAttackLourde;
            }

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        refPlayerManager = collision.gameObject.GetComponentInChildren<PlayerManager>();
        isEnnemyUnderAttack = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        //if (collision.gameObject == ) { }
        isEnnemyUnderAttack = false;
    }
}
