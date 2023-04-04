using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLifeBar : MonoBehaviour
{
    // Start is called before the first frame update
    static Image LifeBar;
    public float max { get; set; }
    private float CurrentLife;
    public float currentlife
    {
        get { return CurrentLife; } set {
        
        CurrentLife = Mathf.Clamp(currentlife,0,max);
            LifeBar.fillAmount = (1 / max) * CurrentLife;
        }
    }
    void Start()
    {
        LifeBar = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
