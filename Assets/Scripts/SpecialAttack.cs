using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialAttack : MonoBehaviour
{
    public float speed = 1;

    // Update is called once per frame
    void Update()
    {
        transform.position += speed * Time.deltaTime * new Vector3(20f,0,0);
    }

    private void OnCollisionEnter2D()
    {
        Destroy(gameObject);
    }
}
