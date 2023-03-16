using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BoutonSuivant : MonoBehaviour
{
    public float positionjoueuer1;
    public float positionjoueuer2;

    public string sceneSuivante;
    public GameObject joueur1;
    public GameObject joueur2;
    public void suivant() 
    {
        positionjoueuer1 = joueur1.transform.position.x ;
        positionjoueuer2 = joueur2.transform.position.x;
        if ((joueur1.transform.position.x == 6 && joueur2.transform.position.x == - 6) || (joueur1.transform.position.x == -6 && joueur2.transform.position.x == 6))
        {
                GameManager.position1 = positionjoueuer1;
            GameManager.position2 = positionjoueuer2;
                Debug.Log(positionjoueuer1);
            Debug.Log("lol");
            SceneManager.LoadScene(sceneSuivante);
        }
    }
}
