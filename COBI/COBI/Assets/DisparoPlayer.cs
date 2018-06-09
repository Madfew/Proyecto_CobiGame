using UnityEngine;

public class DisparoPlayer : MonoBehaviour {

    public bool disparo;

    public MovBala bala;
    public float velocidadBala;
    public float velocidadDisparo;
    public float tiempoEspera;
    public Transform salidaBala;
    
    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {

        Disparar();
      
	}

    void Disparar()
    {
        if (disparo == true)
        {
            tiempoEspera -= Time.deltaTime;
            if(tiempoEspera <= 0)
            {
                tiempoEspera = velocidadDisparo;
                MovBala newBala = Instantiate(bala, salidaBala.position, salidaBala.rotation) as MovBala;
                newBala.velocidad = velocidadBala;
            }
        }
    }
}
