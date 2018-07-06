using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VidaJugador : MonoBehaviour {

    public int vidaIncial = 100;
    public int vidaActual;
    public Image dañoImagen;
    public float flashVelocidad = 5f;
    public Color flashColor = new Color(1, 0f, 0f, 0.1f);

    AudioSource jugadorAudio;
    MovJugador jugador;
    bool muerto;
    bool daño;

    // Use this for initialization
    void Start()
    {
        jugadorAudio = GetComponent<AudioSource>();
        jugador = GetComponent<MovJugador>();
        vidaActual = vidaIncial;
    }

    // Update is called once per frame
    void Update()
    {
        if (daño)
        {
            dañoImagen.color = flashColor;
        }
        else
        {
            dañoImagen.color = Color.Lerp(dañoImagen.color, Color.clear, flashVelocidad * Time.deltaTime);
        }
        daño = false;
    }

    public void RecibeDaño(int valorDaño)
    {
        daño = true;
        vidaActual -= valorDaño;
        jugadorAudio.Play();
        if (vidaActual <= 0 && !muerto)
        {
            Muerto();
        }
        jugadorAudio.Play();
    }

    void Muerto()
    {
        muerto = true;
        jugador.enabled = false;
    }
}
