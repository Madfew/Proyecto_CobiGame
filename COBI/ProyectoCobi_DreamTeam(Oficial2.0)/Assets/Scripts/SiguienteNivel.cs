using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SiguienteNivel : MonoBehaviour {

    float timer;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Finish")
        {
            if(Scoremanager.puntaje >= 280)
            {
                if (Scoremanager.puntaje >= 400)
                {
                    SceneManager.LoadScene("JuegoFinal"); //SceneManager.LoadScene("Victoria");
                }

                Debug.Log("Pasaste de nivel");

                TilesManager.velocidad = 40;
                PlataformaManager.velocidad = 50f;
                EnemigoMov.velocidad = 25f;

            }
            else
            {
                SceneManager.LoadScene("Juego");
            }
        }
    }
}
