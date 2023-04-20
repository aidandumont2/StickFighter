using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Image = UnityEngine.UI.Image;

public class Fin : MonoBehaviour
{
    public static Sprite player1;
    public static Sprite player2;
    public static int player1Life;
    public static int player2Life;
    public static float Time;
    public TextMeshProUGUI Times;
    public TextMeshProUGUI Gagnant;
    public TextMeshProUGUI Perdant;
    public GameObject Winner;
    public GameObject Looser;
    private void Start()
    {
        Times.text = Time.ToString();
        if (player1Life > player2Life)
        {
            Winner.gameObject.GetComponent<Image>().sprite = player1;
            Gagnant.text = player1Life.ToString();
            Looser.gameObject.GetComponent<Image>().sprite = player2;
            Perdant.text = player2Life.ToString();
        }else if(player1Life > player2Life)
        {
            Winner.gameObject.GetComponent<Image>().sprite = player2;
            Gagnant.text = player2Life.ToString();
            Looser.gameObject.GetComponent<Image>().sprite = player1;
            Perdant.text = player1Life.ToString();
        }
        
        
        
    }
}
