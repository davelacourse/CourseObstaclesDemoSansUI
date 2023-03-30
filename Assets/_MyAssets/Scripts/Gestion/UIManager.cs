using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TMP_Text _txtAccrochages = default;
    [SerializeField] private TMP_Text _txtTemps = default;
    [SerializeField] private GameObject _panneauPause = default;
    private bool _enPause;

    private GestionJeu _gestionJeu;
    private Player _player;

    private void Start()
    {
        _gestionJeu = FindObjectOfType<GestionJeu>();
        _player = FindObjectOfType<Player>();
        _panneauPause.SetActive(false);
        _enPause = false;
    }

    private void Update()
    {
        AffichageTemps();
        if (Input.GetKeyDown(KeyCode.Escape) && !_enPause)
        {
            AfficherPanneau();
        }
        else if(Input.GetKeyDown(KeyCode.Escape) && !_enPause)
        {
            FermerPanneau();
        }


    }



    private void AffichageTemps()
    {
        if (!_player.GetABouger() && SceneManager.GetActiveScene().buildIndex == 1)
        {
            _txtTemps.text = "Temps : 0.00";
        }
        else if (_player.GetABouger() && SceneManager.GetActiveScene().buildIndex == 1)
        {
            float temps = Time.time - _player.GetTempsDepart();
            _txtTemps.text = "Temps : " + temps.ToString("f2");
        }
    }

    public void ChangerPointage(int p_pointage)
    {
        _txtAccrochages.text = "Accrochages : " + p_pointage.ToString(); 
    }

    public void AfficherPanneau()
    {
        _panneauPause.SetActive(true);
        Time.timeScale = 0;
        _enPause = true;
    }

    public void FermerPanneau()
    {
        _panneauPause.SetActive(false);
        Time.timeScale = 1;
        _enPause = false;
    }

    public void ChargerSceneDepart()
    {
        SceneManager.LoadScene(0);
    }

    public void Quitter()
    {
        Application.Quit();
    }
}
