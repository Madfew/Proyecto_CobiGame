using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class MovJugador : MonoBehaviour {

    float dirX;
    Vector3 salto;
    Rigidbody rb;

    [Header("MovimientoPersonaje")]
    [Range(1f, 50f)]
    public float velocidadMov = 5f;

    [Header("Salto")]
    [Range(100f, 2500f)]
    public float saltoFuerza = 500f;
    public int saltar;

    void Start () {

        rb = GetComponent<Rigidbody>();

	}
	
	void Update () {
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector3(dirX * velocidadMov, rb.velocity.y, 0);

        dirX = CrossPlatformInputManager.GetAxis("Horizontal");

        if (saltar < 1)
        {
            if (Input.GetKeyDown(KeyCode.Space)) //if(CrossPlatformInputManager.GetButtonDown("Salto"))
            {
                Saltar();
            }
        }

    }

    private void Saltar()
    {
        rb.AddForce(Vector3.up * saltoFuerza);
        saltar = saltar + 1;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Piso")
        {
            saltar = 0;
        }
    }

}
