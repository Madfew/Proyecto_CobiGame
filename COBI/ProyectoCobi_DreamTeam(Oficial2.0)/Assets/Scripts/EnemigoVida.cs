using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoVida : MonoBehaviour {

    public int vidaInicial = 40;
    public int vidaReciente;
    public float tiempoHundiendose = 2.5f;
    public AudioClip muerteAudio;
    public int ScoreValue = 20;

    AudioSource enemigoAudio;
    ParticleSystem particulasHit;
    CapsuleCollider capsulaCollider;
    bool muerto;
    EnemigoMov enemigo;
    //bool hundiendose;
    //Enemys enemigo;

    void Start()
    {
        enemigoAudio = GetComponent<AudioSource>();
        particulasHit = GetComponentInChildren<ParticleSystem>();
        capsulaCollider = GetComponent<CapsuleCollider>();
        enemigo = GetComponent<EnemigoMov>();
        vidaReciente = vidaInicial;
    }

    void Update()
    {
        //if (hundiendose)
        //{
        //    transform.Translate(-Vector3.up * tiempoHundiendose * Time.deltaTime);
        //}
    }

    public void recibeDaño(int cantidad, Vector3 puntoHit)
    {

        if (muerto)
            return;

        enemigoAudio.Play();
        vidaReciente -= cantidad;

        particulasHit.transform.position = puntoHit;
        particulasHit.Play();

        if (vidaReciente <= 0)
        {
            Muriendo();
        }
    }

    void Muriendo()
    {
        Debug.Log("Muerte");

        muerto = true;

        capsulaCollider.isTrigger = true;

        //EmpezarHundirse();

        enemigoAudio.clip = muerteAudio;
        enemigoAudio.Play();
        Scoremanager.puntaje += ScoreValue;
        enemigo.enabled = false;
        GetComponent<Rigidbody>().isKinematic = true;
        Destroy(gameObject, 1f);
    }
}
