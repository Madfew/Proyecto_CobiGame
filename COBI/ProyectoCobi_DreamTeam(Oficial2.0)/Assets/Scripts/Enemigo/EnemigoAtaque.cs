using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoAtaque : MonoBehaviour {

    public int ataqueDaño = 20;

    GameObject jugador;
    VidaJugador vidaJugador;

    // Use this for initialization
    void Start()
    {
        jugador = GameObject.FindGameObjectWithTag("Player");
        vidaJugador = jugador.GetComponent<VidaJugador>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Ataque();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Ataque();
        }
    }

    void Ataque()
    {
        if (vidaJugador.vidaActual > 0)
        {
            vidaJugador.RecibeDaño(ataqueDaño);
        }
    }
}
