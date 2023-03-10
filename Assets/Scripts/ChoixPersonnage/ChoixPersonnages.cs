using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Image = UnityEngine.UI.Image;

public class ChoixPersonnages : MonoBehaviour
{
    public GameObject Joueur1;
    public Sprite Batman;
    public Sprite Dio;
    public Sprite Doomsday;
    public Sprite CaptainFalcon;
    public Sprite Flash;
    public Sprite ReverseFlash;
    private bool Player1;
    private bool Player2;

    public void choixPersonnages(string personnage)
    {
        if (personnage == "Batman")
        {
            Joueur1.gameObject.GetComponent<Image>().sprite = Batman;
        }
        if (personnage == "Dio")
        {
            Joueur1.gameObject.GetComponent<Image>().sprite = Dio;
        }
        if (personnage == "Doomsday")
        {
            Joueur1.gameObject.GetComponent<Image>().sprite = Doomsday;
        }
        if (personnage == "CaptainFalcon")
        {
            Joueur1.gameObject.GetComponent<Image>().sprite = CaptainFalcon;
        }
        if (personnage == "Flash")
        {
            Joueur1.gameObject.GetComponent<Image>().sprite = Flash;
        }
        if (personnage == "ReverseFlash")
        {
            Joueur1.gameObject.GetComponent<Image>().sprite = ReverseFlash;
        }
    }
    public void SceneChargement(string sceneSuivante)
    {

        if (Joueur1.gameObject.GetComponent<Image>().sprite == true && Joueur1.gameObject.GetComponent<Image>().sprite == true)
        {
            SceneManager.LoadScene(sceneSuivante);
        }
    }

}
