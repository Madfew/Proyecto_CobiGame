using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VIH : MonoBehaviour {

    Animator anim;
    float timer;

	// Use this for initialization
	void Start () {
        anim = GetComponentInChildren<Animator>();
	}
	
	// Update is called once per frame
	void Update () {

		if(Scoremanager.puntaje == 200)
        {
            Muerto();
            SceneManager.LoadScene("Victoria");
        }
	}

    public void Muerto()
    {
        anim.SetTrigger("Muerto");
    }

}
