using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GestionScenes : MonoBehaviour
{
    public void Quitter()
    {
        Application.Quit();
    }

    public void ChargerSceneSuivante()
    {
        int noScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(noScene + 1);
    }

    public void ChargerSceneDepart()
    {
        SceneManager.LoadScene(0);
    }
}
