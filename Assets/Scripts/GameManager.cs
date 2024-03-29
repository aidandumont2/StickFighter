using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using Image = UnityEngine.UI.Image;


public class GameManager : MonoBehaviour
{
    public static string personnages;
    public GameObject ChoixPersonnage1;
    public GameObject ChoixPersonnage2;
    private Image joueur1;
    private Image joueur2;
    public Button bouton;
    public static string PersonnageJ1;
    public static string PersonnageJ2;
    private Color colors = new Color(1f, 0.9764706f, 0.9764706f, 1f);
 
    private void Start()
    {
        joueur1 = ChoixPersonnage1.gameObject.GetComponent<Image>();
        joueur2 = ChoixPersonnage2.gameObject.GetComponent<Image>();
    }
   
    private void Update()
    {
        if (SceneManager.GetActiveScene().name != "ChoixCamps" )
        {
            if (joueur1.color != Color.red && joueur2.color != Color.blue)
               {
                Debug.Log(joueur1 + " " + joueur2);
                Debug.Log("Les 2 on un perso");
                bouton.GetComponent<Image>().color = Color.red;
            }
        }
        
 
    }public static void FinCombat()
        {
            Debug.Log("Fin du combat");
            Fin.Time =  Temps.timeRemaining;
            SceneManager.LoadScene("SceneFinCombat");
        }
}
