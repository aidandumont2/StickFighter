using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camps1 : MonoBehaviour
{
 public Material defaultmaterial;
    public Color couleurJoueur;
    public string Joueur = "";

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Joueur1") || other.gameObject.CompareTag("Joueur2"))
        {
            GameObject box = other.gameObject;
            SpriteRenderer[] Joueur = box.GetComponentsInChildren<SpriteRenderer>(true);
            for (int i = 0; i < Joueur.Length; i++)
            {
                Material[] materials = Joueur[i].materials;
                Material material = materials[0];
                Color color = material.color;
                defaultmaterial = material;
                material.color = Color.red;
            }

        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Joueur1") || other.gameObject.CompareTag("Joueur2"))
        {
            GameObject box = other.gameObject;
            SpriteRenderer[] Joueur = box.GetComponentsInChildren<SpriteRenderer>(true);
            for (int i = 0; i < Joueur.Length; i++)
            {
                Material[] materials = Joueur[i].materials;
                Material material = materials[0];
                Color color = material.color;
                defaultmaterial = material;
                material.color = Color.white;
            }
        }
    }
}
