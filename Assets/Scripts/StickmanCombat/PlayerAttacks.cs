using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttacks : MonoBehaviour
{
    public GameObject attackSpecial;
    Animator anim;
    private void Start()
    {
        anim = GetComponent<Animator>(); 
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            anim.Play("LancerBatarang");
            Instantiate(attackSpecial, transform.position + new Vector3(1.5f,0,0), Quaternion.identity);
            
        }
    }
}
