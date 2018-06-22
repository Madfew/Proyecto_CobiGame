using UnityEngine;

public class MovBala : MonoBehaviour {

    public float velocidad = 500f;

	// Use this for initialization
	void Start () {
        Destroy(gameObject, 2f);
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.forward * velocidad * Time.deltaTime);
	}

    private void OnCollisionEnter(Collision target)
    {
        if(target.gameObject.tag == "Enemigo")
        {
            Destroy(gameObject);
        }
    }

}
