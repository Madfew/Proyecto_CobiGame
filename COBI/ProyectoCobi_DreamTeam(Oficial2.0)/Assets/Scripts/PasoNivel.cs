using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PasoNivel : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject, 5f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject, 1f);
    }
}
