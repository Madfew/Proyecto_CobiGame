using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class MovPlayer : MonoBehaviour {

    float dirX;
    Vector3 direccion, salto;
    Rigidbody rb;

    [Header("MovimientoPersonaje")]
    [Range(1f,20f)]
    public float velocidadMov = 5f;

    [Header("Salto")]
    [Range(100f, 1500f)]
    public float saltoFuerza = 500f;
    public int saltar;

    DisparoPlayer playerDispara;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        playerDispara = GetComponentInChildren<DisparoPlayer>();
	}
	
	// Update is called once per frame
	void Update () {

        dirX = CrossPlatformInputManager.GetAxis("Horizontal");
        direccion = new Vector3(dirX, 0, 0);

        if (saltar < 1)
        {
            if (CrossPlatformInputManager.GetButtonDown("Salto"))
            {
                Saltar();
            }
        }

        if (CrossPlatformInputManager.GetButton("Disparo"))
        {
            //Debug.Log("Estoy disparando");
            playerDispara.disparo = true;
        } else {
            playerDispara.disparo = false;
        }

    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector3(dirX * velocidadMov, rb.velocity.y, 0);
    }

    private void Saltar()
    {
        rb.AddForce(Vector3.up * saltoFuerza);
        saltar = saltar + 1;
    }

    private void OnCollisionEnter(Collision collision)
    {
        saltar = 0;
    }

}
