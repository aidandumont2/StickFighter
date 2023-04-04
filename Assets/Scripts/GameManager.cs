using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    void Update()
    {
        
    }

    public static void FinCombat()
    {
        Debug.Log("Fin du combat");
        SceneManager.LoadScene("SceneFinCombat");
    }
}
