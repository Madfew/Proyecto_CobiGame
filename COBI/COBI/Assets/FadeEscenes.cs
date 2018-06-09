using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeEscenes : MonoBehaviour {

    private CanvasGroup grupoFade;
    private float velocidadFade = 0.3f;

    private void Start()
    {
        grupoFade = FindObjectOfType<CanvasGroup>();
        grupoFade.alpha = 1;
    }

    private void Update()
    {
        grupoFade.alpha = 1 - Time.timeSinceLevelLoad * velocidadFade;
    }
}
