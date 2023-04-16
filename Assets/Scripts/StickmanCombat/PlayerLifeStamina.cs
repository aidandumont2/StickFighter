using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLifeStamina : MonoBehaviour
{
    public Slider slider;
    public PlayerManager player;
    // Start is called before the first frame update

    private void Update()
    {
        SetHealth();
    }
    public void SetHealth()
    {
        slider.value = player.lifepoint;
    }
}
