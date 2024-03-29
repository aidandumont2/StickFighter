using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class DétectionBouton : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        GameObject box = other.gameObject;
        
        if (other.gameObject.CompareTag("BoutonMenu"))
        {            
           box.GetComponent<Image>().color = new Color32(255, 255, 225, 100);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("BoutonMenu"))
        {
            GameObject box = other.gameObject;
            box.GetComponent<Image>().color = Color.white;
        }
    }
}
