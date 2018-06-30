using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Menuactions : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void CargarEscena()
    {
        SceneManager.LoadScene("Cinematicas");
    }
    public void Cargarmenuprincipal()
    {
        SceneManager.LoadScene("MenuPrincipal");
    }
    public void volveraintentar()
    {
        SceneManager.LoadScene("Juego");
    }

}

