using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangerScène : MonoBehaviour
{
    public void LoadScene(string sceneSuivante)
    {
        SceneManager.LoadScene(sceneSuivante);
    }
}
