using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem.UI;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Image = UnityEngine.UI.Image;

public class ChoixPersonnages : MonoBehaviour
{
    public GameObject Joueur1;
    public GameObject Joueur2;
    public Sprite Batman;
    public Sprite Dio;
    public Sprite Doomsday;
    public Sprite CaptainFalcon;
    public Sprite Flash;
    public Sprite ReverseFlash;
    public GameObject Player1;
    public GameObject Player2;

    public void choixPersonnage(string personnage)
    {
        GameManager.personnages = personnage;

    }
    public void SceneChargement(string sceneSuivante)
    {

        if (Joueur1.gameObject.GetComponent<Image>().sprite == true && Joueur1.gameObject.GetComponent<Image>().sprite == true)
        {
            SceneManager.LoadScene(sceneSuivante);
        }
    }

}
