using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject[] Enemigos;
    public Vector3 spawnValores;
    public float spawnEspera;
    public float spawnEsperaMax;
    public float spawnEsperaMin;
    public int empezarEspera;
    public bool parar;

    int randEnemigos;

	// Use this for initialization
	void Start () {
        StartCoroutine(spawnerEspera());
	}
	
	// Update is called once per frame
	void Update () {
        spawnEspera = Random.Range(spawnEsperaMin, spawnEsperaMax);
	}

    IEnumerator spawnerEspera()
    {
        yield return new WaitForSeconds(empezarEspera);

        while (!parar)
        {
            randEnemigos = Random.Range(0, 2);
            Vector3 spawnPosicion = new Vector3(Random.Range(-spawnValores.x, spawnValores.x), 1, Random.Range(-spawnValores.z, spawnValores.z));
            Instantiate(Enemigos[randEnemigos], spawnPosicion + transform.TransformPoint(0, 0, 0), Quaternion.Euler(0,180,0));
            yield return new WaitForSeconds(spawnEspera);
        }
    }
}
