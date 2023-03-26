using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Image = UnityEngine.UI.Image;

public class Assignation : MonoBehaviour
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
    // Start is called before the first frame update
    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collider");
        if (other.gameObject.CompareTag("Joueur1"))
        {
            if (GameManager.personnages == "Batman")
            {
                Joueur1.gameObject.GetComponent<Image>().sprite = Batman;
            }
            if (GameManager.personnages == "Dio")
            {
                Joueur1.gameObject.GetComponent<Image>().sprite = Dio;
            }
            if (GameManager.personnages == "Doomsday")
            {
                Joueur1.gameObject.GetComponent<Image>().sprite = Doomsday;
            }
            if (GameManager.personnages == "CaptainFalcon")
            {
                Joueur1.gameObject.GetComponent<Image>().sprite = CaptainFalcon;
            }
            if (GameManager.personnages == "Flash")
            {
                Joueur1.gameObject.GetComponent<Image>().sprite = Flash;
            }
            if (GameManager.personnages == "ReverseFlash")
            {
                Joueur1.gameObject.GetComponent<Image>().sprite = ReverseFlash;
            }
        }
        if (other.gameObject.CompareTag("Joueur2"))
        {
            if (GameManager.personnages == "Batman")
            {
                Joueur2.gameObject.GetComponent<Image>().sprite = Batman;
            }
            if (GameManager.personnages == "Dio")
            {
                Joueur2.gameObject.GetComponent<Image>().sprite = Dio;
            }
            if (GameManager.personnages == "Doomsday")
            {
                Joueur2.gameObject.GetComponent<Image>().sprite = Doomsday;
            }
            if (GameManager.personnages == "CaptainFalcon")
            {
                Joueur2.gameObject.GetComponent<Image>().sprite = CaptainFalcon;
            }
            if (GameManager.personnages == "Flash")
            {
                Joueur2.gameObject.GetComponent<Image>().sprite = Flash;
            }
            if (GameManager.personnages == "ReverseFlash")
            {
                Joueur2.gameObject.GetComponent<Image>().sprite = ReverseFlash;
            }
        }
    }
}
