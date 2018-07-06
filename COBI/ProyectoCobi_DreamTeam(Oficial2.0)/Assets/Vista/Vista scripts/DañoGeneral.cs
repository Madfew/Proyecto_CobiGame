using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DañoGeneral : MonoBehaviour
{
    public Image[] hitpoints;
    int vida = 5;
    public Image dañoImagen;
    public float flashVelocidad = 5f;
    public Color flashColor = new Color(1, 0f, 0f, 0.1f);

    AudioSource jugadorAudio;
    MovJugador jugador;
    bool muerto;
    bool daño;

    void Start()
    {
        jugadorAudio = GetComponent<AudioSource>();
        jugador = GetComponent<MovJugador>();
    }


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
    
    private void OnTriggerEnter(Collider obj)
    {
         if (obj.gameObject.tag == "Enemigo")
        {
            Destroy(obj.gameObject, 2f);
            GetHurt();
        }
        if (obj.gameObject.tag == "Pildora")
        {
            Destroy(obj.gameObject);
            recuperarvida();
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemigo")
        {
            GetHurt();
        }
    }

    void GetHurt()
    {
        daño = true;
        if (vida > 0)
        {
            vida = vida - 1;
        }
        jugadorAudio.Play();
        hitpoints[vida].gameObject.SetActive(false);
        if (vida == 0 && !muerto)
        {
            Muerto();
        }
    }

    void recuperarvida()
    {
        if (vida < 5)
        {
            vida = vida + 1;
        }
        hitpoints[vida - 1].gameObject.SetActive(true);

    }

    void Muerto(){
        muerto = true;
        jugador.enabled = false;
        SceneManager.LoadScene("Derrota");
    }
}


