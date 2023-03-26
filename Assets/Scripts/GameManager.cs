using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //public static bool isEndFight = false;
    public static int viePlayer1;
    public static int viePlayer2;
    void Update()
    {
        
    }

    public static void FinCombat()
    {
        Debug.Log("Fin du combat");
        SceneManager.LoadScene("SceneFinCombat");
    }
}
