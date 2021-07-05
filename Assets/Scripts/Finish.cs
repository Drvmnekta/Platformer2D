using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    [SerializeField] private GameObject levelCompleteCanvas;
    [SerializeField] private GameObject massageUI;

    private bool _isActivated = false;
    public void Activate () {
        _isActivated = true;
        massageUI.SetActive(false);
    }

    public void FinishLevel() {
        if(_isActivated){
            gameObject.SetActive(false);
            levelCompleteCanvas.SetActive(true);
            Time.timeScale = 0f;
        } else {
            massageUI.SetActive(true);
        }
    }
}
