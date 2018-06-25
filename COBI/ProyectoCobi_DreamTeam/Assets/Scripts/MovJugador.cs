using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets;

public class MovJugador : MonoBehaviour {

    float dirX;
    Vector3 direccion, salto;
    Rigidbody rb;

    [Header("MovimientoPersonaje")]
    [Range(1f, 20f)]
    public float velocidadMov = 5f;

    [Header("Salto")]
    [Range(100f, 1500f)]
    public float saltoFuerza = 500f;
    public int saltar;

    // Use this for initialization
    void Start () {

        rb = GetComponent<Rigidbody>();

	}
	
	// Update is called once per frame
	void Update () {

		
	}
}
