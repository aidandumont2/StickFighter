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
    public  GameObject Joueur1;
    public  GameObject Joueur2;
    public Sprite Batman;
    public Sprite Dio;
    public Sprite Doomsday;
    public Sprite Akuma;
    public Sprite ReverseFlash;
    public static bool choix=false;

    public void choixPersonnage(string personnage)
    {
        if (choix==false) { 
        GameManager.personnages = personnage;
            Assignation1(personnage);
        }
        else
        {
            GameManager.personnages = personnage;
            Assignation2(personnage);
        }
    }
    public void Assignation1(string other)
    {
            if (other == "Batman")
            {
                Joueur1.gameObject.GetComponent<Image>().sprite = Batman;
            Fin.player1 = Joueur1.gameObject.GetComponent<Image>().sprite;
            Joueur1.gameObject.GetComponent<Image>().color = Color.white;
            GameManager.PersonnageJ1 = "Batman";
            
            choix = true;
            }
            if (other == "Dio")
            {
                Joueur1.gameObject.GetComponent<Image>().sprite = Dio;
            Fin.player1 = Dio;
            Joueur1.gameObject.GetComponent<Image>().color = Color.white;
            GameManager.PersonnageJ1 = "Dio";
            
            choix = true;
            }
            if (other == "Doomsday")
            {
                Joueur1.gameObject.GetComponent<Image>().sprite = Doomsday;
            Fin.player1 = Doomsday;
            Joueur1.gameObject.GetComponent<Image>().color = Color.white;
            GameManager.PersonnageJ1 = "Doomsday";
            
            choix = true;
            }
            if (other == "Akuma")
            {
                Joueur1.gameObject.GetComponent<Image>().sprite = Akuma;
            Fin.player1 = Akuma;
            Joueur1.gameObject.GetComponent<Image>().color = Color.white;
            GameManager.PersonnageJ1 = "Akuma";
            
            choix = true;
            }
            if (other == "ReverseFlash")
            {
                Joueur1.gameObject.GetComponent<Image>().sprite = ReverseFlash;
            Fin.player1 = ReverseFlash;
            Joueur1.gameObject.GetComponent<Image>().color = Color.white;
            GameManager.PersonnageJ1 = "ReverseFlash";
            
            choix = true;
            }
        
        Debug.Log(choix);
        }
    public void Assignation2(string other)
    {
            if (other == "Batman")
            {
                Joueur2.gameObject.GetComponent<Image>().sprite = Batman;
            Fin.player2 = Batman;
            Joueur2.gameObject.GetComponent<Image>().color = Color.white;
            GameManager.PersonnageJ2 = "Batman";
            
        }
            if (other == "Dio")
            {
                Joueur2.gameObject.GetComponent<Image>().sprite = Dio;
            Fin.player2 = Dio;
            Joueur2.gameObject.GetComponent<Image>().color = Color.white;
            GameManager.PersonnageJ2 = "Dio";
            
        }
            if (other == "Doomsday")
            {
                Joueur2.gameObject.GetComponent<Image>().sprite = Doomsday;
            Fin.player2 = Doomsday;
            Joueur2.gameObject.GetComponent<Image>().color = Color.white;
            GameManager.PersonnageJ2 = "Doomsday";
            
        }
            if (other == "Akuma")
            {
                Joueur2.gameObject.GetComponent<Image>().sprite = Akuma;
            Fin.player2 = Akuma;
            Joueur2.gameObject.GetComponent<Image>().color = Color.white;
            GameManager.PersonnageJ2 = "Akuma";
            
        }
            if (other == "ReverseFlash")
            {
                Joueur2.gameObject.GetComponent<Image>().sprite = ReverseFlash;
            Fin.player2 = ReverseFlash;
            Joueur2.gameObject.GetComponent<Image>().color = Color.white;
            GameManager.PersonnageJ2 = "ReverseFlash";
            
        }
        
    }
    public void SceneChargement(string sceneSuivante)
    {

        if (Joueur1.gameObject.GetComponent<Image>().sprite != null && Joueur2.gameObject.GetComponent<Image>().sprite != null)
        {
            SceneManager.LoadScene(sceneSuivante);
        }
    }
    
}
