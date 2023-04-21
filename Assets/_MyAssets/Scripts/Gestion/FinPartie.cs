using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinPartie : MonoBehaviour
{
    // ***** Attributs *****

    [SerializeField] private int _idNiveau = 1;
    private bool _finPartie = false;  // booléen qui détermine si la partie est terminée
    private GestionJeu _gestionJeu; // attribut qui contient un objet de type GestionJeu
    private Player _player;  // attribut qui contient un objet de type Player

    // ***** Méthode privées  *****
    
    private void Start()
    {
        _gestionJeu = FindObjectOfType<GestionJeu>();  // récupère sur la scène le gameObject de type GestionJeu
        _player = FindObjectOfType<Player>();  // récupère sur la scène le gameObject de type Player
    }

    /*
     * Méthode qui se produit quand il y a collision avec le gameObject de fin
     */
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player" && !_finPartie)  // Si la collision est produite avec le joueur et la partie n'est pas terminée
        {
            _finPartie = true; // met le booléen à vrai pour indiquer la fin de la partie
            int noScene = SceneManager.GetActiveScene().buildIndex; // Récupère l'index de la scène en cours
            _gestionJeu.SetNiveau(_gestionJeu.GetPointage(), Time.time - _player.GetTempsDepart(), _idNiveau);
            SceneManager.LoadScene(noScene + 1);
        }
    }
}
