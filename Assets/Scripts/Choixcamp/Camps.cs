using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camps : MonoBehaviour
{
 public Material defaultmaterial;
    public Color couleurJoueur;
    
    private void OnTriggerEnter(Collider other)
    {
       
        if (other.gameObject.CompareTag("Joueur1") || other.gameObject.CompareTag("Joueur2"))
        {
            Debug.Log("La caisse est dans la place");
            GameObject box = other.gameObject;
            SpriteRenderer Joueur = box.GetComponentInChildren<SpriteRenderer>(true);
            SpriteRenderer renderer = Joueur.GetComponent<SpriteRenderer>();
            Material[] materials = renderer.materials;
            Material material = materials[0];
            Color color = material.color;
            defaultmaterial = material;
            material.color = Color.red;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Joueur1") || other.gameObject.CompareTag("Joueur2"))
        {
            Debug.Log("La caisse n'est plus dans la place");
            GameObject box = other.gameObject;
            SpriteRenderer Joueur = box.GetComponentInChildren<SpriteRenderer>();
            SpriteRenderer renderer = Joueur.GetComponent<SpriteRenderer>();
            Material[] materials = renderer.materials;
            Material material = materials[0];
            Color color = material.color;
            material.color = Color.white;
        }
    }
}