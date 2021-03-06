﻿using System.Collections;
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
    Animator anim;
    EnemigoMov enemigo;
    bool muerto;
    bool hundiendose;

    private GameObject vida;

    void Start()
    {
        enemigoAudio = GetComponent<AudioSource>();
        particulasHit = GetComponentInChildren<ParticleSystem>();
        capsulaCollider = GetComponent<CapsuleCollider>();
        enemigo = GetComponent<EnemigoMov>();
        anim = GetComponentInChildren<Animator>();
        vidaReciente = vidaInicial;

        hundiendose = false;

        vida = GameObject.Find("BarraVidaEnemigo");
    }

    void Update()
    {
        if (hundiendose)
        {
            transform.Translate(-Vector3.up * tiempoHundiendose * Time.deltaTime);
        }
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

    public void EmpezarHundirse()
    {
        anim.SetTrigger("Muerto");
        hundiendose = true;
        Destroy(gameObject, 2f);
    }

    void Muriendo()
    {
        muerto = true;

        capsulaCollider.isTrigger = true;

        EmpezarHundirse();

        enemigoAudio.clip = muerteAudio;
        enemigoAudio.Play();
        Scoremanager.puntaje += ScoreValue;

        vida.SendMessage("Daño", 10);

        enemigo.enabled = false;
        GetComponent<Rigidbody>().isKinematic = true;
    }
}
