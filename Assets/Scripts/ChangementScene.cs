using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangementScene : MonoBehaviour
{
    public void RetourMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void ScèneAideCommande()
    {
        SceneManager.LoadScene(1);
    }
    public void Scènechoixcamps()
    {
        SceneManager.LoadScene(2);
    }
}
