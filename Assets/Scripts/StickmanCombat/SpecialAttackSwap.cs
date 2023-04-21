using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialAttackSwap : MonoBehaviour
{
    public float speed = 1;
    

    // Update is called once per frame
    void Update()
    {
        lancementAttSpe(-speed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.gameObject.GetComponentInChildren<PlayerManager>().lifepoint -= 20;
        Destroy(gameObject);
    }

    private void lancementAttSpe(float speed)
    {
        transform.position += speed * Time.deltaTime * new Vector3(-7f, 0, 0);
    }


}
