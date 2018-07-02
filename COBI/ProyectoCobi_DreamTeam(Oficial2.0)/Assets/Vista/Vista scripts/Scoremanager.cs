using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoremanager : MonoBehaviour
{

    public static int puntaje;

    Text text;

    void Awake()
    {

        text = GetComponent<Text>();
        puntaje = 0;
    }


    void Update()
    {

        text.text = "Puntaje:" + puntaje;
    }
}
