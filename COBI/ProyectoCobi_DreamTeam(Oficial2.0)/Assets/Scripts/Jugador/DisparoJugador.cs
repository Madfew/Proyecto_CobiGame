using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoJugador : MonoBehaviour {

    public int daño = 10;
    public float tiempoEntreDisparo = 0.15f;
    public float rango = 50f;

    float tiempo;
    Ray rayoDisparo;
    RaycastHit hitDisparo;
    int capas;
    ParticleSystem disparoParticulas;
    LineRenderer lineaDisparo;
    AudioSource audioDisparo;
    float tiempoEfectos = 0.2f;
    Animator anim;

    void Start()
    {
        capas = LayerMask.GetMask("ZonaDisparo");
        disparoParticulas = GetComponent<ParticleSystem>();
        lineaDisparo = GetComponent<LineRenderer>();
        audioDisparo = GetComponent<AudioSource>();
        anim = GetComponentInParent<Animator>();
    }

    void Update()
    {
        tiempo += Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Z) && tiempo >= tiempoEntreDisparo && Time.timeScale != 0)
        {
            Disparando();
            anim.SetBool("enDisparo",true);
        }
        else
        {
            if (Input.GetKeyUp(KeyCode.Z))
            {
                anim.SetBool("enDisparo", false);
            }
        }

        if (tiempo >= tiempoEntreDisparo * tiempoEfectos)
        {
            DesactivarEfectos();
        }

    }

    public void DesactivarEfectos()
    {
        lineaDisparo.enabled = false;
    }

    void Disparando()
    {
        tiempo = 0f;

        audioDisparo.Play();

        disparoParticulas.Stop();
        disparoParticulas.Play();

        lineaDisparo.enabled = true;
        lineaDisparo.SetPosition(0, transform.position);

        rayoDisparo.origin = transform.position;
        rayoDisparo.direction = transform.forward;

        if (Physics.Raycast(rayoDisparo, out hitDisparo, rango, capas))
        {
            EnemigoVida enemigoVida = hitDisparo.collider.GetComponent<EnemigoVida>();
            if (enemigoVida != null)
            {
                enemigoVida.recibeDaño(daño, hitDisparo.point);
            }
            lineaDisparo.SetPosition(1, hitDisparo.point);
        }
        else
        {
            lineaDisparo.SetPosition(1, rayoDisparo.origin + rayoDisparo.direction * rango);
        }
    }
}
