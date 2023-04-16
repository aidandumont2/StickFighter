using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BoutonSuivant : MonoBehaviour
{
    public string sceneSuivante;
    public GameObject joueur1;
    public GameObject joueur2;
    public void suivant() 
    {
        if ((joueur1.transform.position.x == 6 && joueur2.transform.position.x == - 6) || (joueur1.transform.position.x == -6 && joueur2.transform.position.x == 6))
        {
            if(joueur1.transform.position.x == 6)
            {
            }
            Debug.Log("lol");
            SceneManager.LoadScene(sceneSuivante);
        }
    }
}
