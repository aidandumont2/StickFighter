using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBoxPlayerAttack : MonoBehaviour
{
    private PlayerManager refPlayerManager;
    public bool isEnnemyUnderAttack = false;
    public int damageAttackLegere = 5;
    public int damageAttackLourde = 10;

    // Update is called once per frame
    public void ActiveHitBox(string typeAttack)
    {
        //gameObject.GetComponentInChildren<GameObject>().SetActive(true);
        if (isEnnemyUnderAttack == true)
        {
            Debug.Log("touché");
            if (typeAttack == "Legere")
            {
                refPlayerManager.lifepoint -= damageAttackLegere;
                if (refPlayerManager.gameObject.CompareTag("1"))
                {
                    Debug.Log("Vrai");
                    Fin.player1Life = refPlayerManager.lifepoint;
                    Debug.Log(Fin.player1Life);
                }
                else if (refPlayerManager.gameObject.CompareTag("2"))
                {
                    Debug.Log("Vrai2");
                    Fin.player2Life = refPlayerManager.lifepoint;
                    Debug.Log(Fin.player2Life);
                }
            }
            else if (typeAttack == "Lourde")
            {
                refPlayerManager.lifepoint -= damageAttackLourde;
                if (refPlayerManager.CompareTag("1"))
                {
                    Fin.player1Life = refPlayerManager.lifepoint;
                    Debug.Log(Fin.player1Life);
                }
                else if (refPlayerManager.CompareTag("2"))
                {
                    Fin.player2Life = refPlayerManager.lifepoint;
                    Debug.Log(Fin.player2Life);
                }
            }

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Enter");
        Debug.Log(collision.gameObject.name);
        //gameObject.SetActive(true);
        if (collision.gameObject.name == "HitBoxAttack")
        {
            refPlayerManager = collision.gameObject.GetComponentInParent<PlayerManager>();
            isEnnemyUnderAttack = true;
            collision.gameObject.GetComponentInParent<HitBoxPlayerAttack>().isEnnemyUnderAttack = true;
        }

        //Debug.Log(refPlayerManager);
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("Sortie");
        Debug.Log(collision.gameObject.name);
        //gameObject.SetActive(true);
        if (collision.gameObject.name == "HitBoxAttack")
        {
            isEnnemyUnderAttack = false;
            collision.gameObject.GetComponentInParent<HitBoxPlayerAttack>().isEnnemyUnderAttack = false;
        }

        //Debug.Log(refPlayerManager);
    }
    
    private void Start()
    {
        Fin.player1Life = 100;
        Fin.player2Life = 100;
    }
}