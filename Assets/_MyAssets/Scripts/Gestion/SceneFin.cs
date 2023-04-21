using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class SceneFin : MonoBehaviour
{
    [SerializeField] private TMP_Text _txtTempsTotal = default;
    [SerializeField] private TMP_Text _txtAccroTotal = default;
    [SerializeField] private TMP_Text _txtPointageTotal = default;
    private GestionJeu _gestionJeu;

    private void Start()
    {
        _gestionJeu = FindObjectOfType<GestionJeu>();
        float temps = _gestionJeu.GetTempsNiveau(1) + _gestionJeu.GetTempsNiveau(2);
        _txtTempsTotal.text = "Temps total : " + temps.ToString("f2");
        _txtAccroTotal.text = "Nombres d'accrochages : " + _gestionJeu.GetPointage();
        float total = temps + _gestionJeu.GetPointage();
        _txtPointageTotal.text = "Pointage final : " + total.ToString("f2");
    }

    public void Quitter()
    {
        Application.Quit();
    }

    public void ChargerSceneDepart()
    {
        SceneManager.LoadScene(0);
    }
}
