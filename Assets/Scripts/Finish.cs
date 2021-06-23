using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    [SerializeField] private GameObject levelCompleteCanvas;

    private bool _isActivated = false;
    public void Activate () {
        _isActivated = true;
    }

    public void FinishLevel() {
        if(_isActivated){
        gameObject.SetActive(false);
        levelCompleteCanvas.SetActive(true);
        }
    }
}
