using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public float timeRemaining = 60;
    public TextMeshProUGUI Times;
    // Start is called before the first frame update
    void Start()
    {
        Times.text = timeRemaining.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            Times.text = timeRemaining.ToString("0");
        }
        if (timeRemaining <= 0)
        {
            GameManager.FinCombat();
        }
    }
}
