using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JugadorFade : MonoBehaviour {

    public MovJugador jugador;
    public DisparoJugador disparo;

    // Use this for initialization
    void Start()
    {
        jugador = GetComponent<MovJugador>();
        disparo = GetComponentInChildren<DisparoJugador>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "ZonaVena")
        {
            transform.position = new Vector3(0, -15.55f, 16);
            jugador.enabled = false;
            disparo.enabled = false;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "ZonaVena")
        {
            jugador.enabled = true;
            disparo.enabled = true;
        }
    }
}
