using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DetectionJoueur : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        GameObject box = other.gameObject;

        if (other.gameObject.CompareTag("Joueur1"))
        {
            box.GetComponent<Image>().color = Color.red; ;
        }
        else if (other.gameObject.CompareTag("Joueur2"))
        {
            box.GetComponent<Image>().color= Color.blue;
        }
    }
}
