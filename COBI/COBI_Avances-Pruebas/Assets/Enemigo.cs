using System.Collections;
using UnityEngine;

public class Enemigo : MonoBehaviour {

    int vida = 100;

    public float velocidadMax = 1f;
    public float velocidad = 1f;

    Rigidbody rbEnemigo;

	// Use this for initialization
	void Start () {
        rbEnemigo = GetComponent<Rigidbody>();
	}

    private void FixedUpdate()
    {
        rbEnemigo.AddForce(Vector3.back * velocidad);
        float limiteVelocidad = Mathf.Clamp(rbEnemigo.velocity.z, -velocidadMax, velocidadMax);
        rbEnemigo.velocity = new Vector3(0, 0, limiteVelocidad);
    }

    // Update is called once per frame
    void Update () {
		if(vida == 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Bala")
        {
            Destroy(col.gameObject);
            vida = vida - 20;
        }
    }
    
}
