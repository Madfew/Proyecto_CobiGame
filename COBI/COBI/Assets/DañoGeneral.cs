using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DañoGeneral : MonoBehaviour {

    int vida = 30;
    int vida2 = 30;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}

    private void OnCollisionEnter(Collision enemigo)
    {
        if (enemigo.gameObject.tag == "Enemigo")
        {
            vida = vida - 10;
            Destroy(enemigo.gameObject, 1f);
        }

        if(vida == 0)
        {
            SceneManager.LoadScene(3);
        }
    }
  
}
