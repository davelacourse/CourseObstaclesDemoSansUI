using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneDepart : MonoBehaviour
{
    [SerializeField] private GameObject _boutonInstructions = default;
    [SerializeField] private GameObject _boutonDemarrer = default;
    [SerializeField] private GameObject _boutonQuitter = default;
    [SerializeField] private GameObject _panneauPause = default;

    public void FermerInstructions()
    {
        _panneauPause.SetActive(false);
        _boutonInstructions.SetActive(true);
        _boutonDemarrer.SetActive(true);
        _boutonQuitter.SetActive(true);
    }

    public void OuvrirInstructions()
    {
        _panneauPause.SetActive(true);
        _boutonInstructions.SetActive(false);
        _boutonDemarrer.SetActive(false);
        _boutonQuitter.SetActive(false);
    }
}
