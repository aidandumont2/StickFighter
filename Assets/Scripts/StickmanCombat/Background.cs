using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class Background : MonoBehaviour
{
    public Sprite background1;
    public Sprite background2;
    public Sprite background3;
    public Sprite background4;
    public SpriteRenderer backgrounds;
    void Start()
    {
        randomBackground();
    }
    public void randomBackground()
    {
        int random = Random.Range(1, 4);
        if(random == 1)
        {
            backgrounds.sprite = background1;
        }
        if (random == 2)
        {
            backgrounds.sprite = background2;
        }
        if (random == 3)
        {
            backgrounds.sprite = background3;
        }
        if (random == 4)
        {
            backgrounds.sprite = background4;
        }
        Debug.Log(random);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
