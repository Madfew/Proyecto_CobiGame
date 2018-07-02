using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour {

    public Vector3 end;
    public Vector3 fadePunto;
    public Vector3 saltoPunto;
    float velocidad = 15f;
    float velocidadMax = 20f;
    Quaternion rotacionInicial;
    bool fade;
    MovJugador jugador;

    // Use this for initialization
    void Start()
    {
        jugador = GetComponentInChildren<MovJugador>();
        rotacionInicial = transform.rotation;
        fade = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (fade == false)
        {
            transform.rotation = rotacionInicial;
            if (jugador.saltar == 0)
            {
                transform.position = Vector3.MoveTowards(transform.position, end, velocidadMax * Time.deltaTime);

            }
            else
            {
                transform.position = Vector3.MoveTowards(transform.position, saltoPunto, velocidad * Time.deltaTime);
            }
        }
        if (fade == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, fadePunto, velocidad * Time.deltaTime);
            transform.rotation = new Quaternion(0, 0, 0, 0);
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ZonaVena")
        {
            fade = true;
        }
    }
    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "ZonaVena")
        {
            fade = false;
        }
    }
}
