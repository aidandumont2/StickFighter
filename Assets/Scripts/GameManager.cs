using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject Player1;
    public GameObject Player2;
    private Scene sceneCombat;

    void Start()
    {
        sceneCombat = SceneManager.GetActiveScene();
        Debug.Log(sceneCombat);
        Debug.Log(sceneCombat.GetRootGameObjects());
    }
}
