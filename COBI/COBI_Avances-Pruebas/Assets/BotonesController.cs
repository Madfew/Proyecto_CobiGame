using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonesController : MonoBehaviour {

    public void CargarNivel(string EscenaNombre)
    {
        SceneManager.LoadScene(EscenaNombre);
    }

    public void SalirJuego()
    {
        Application.Quit();
        UnityEditor.EditorApplication.isPlaying = false;
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}
}
