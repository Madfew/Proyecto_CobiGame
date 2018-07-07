using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformaManager : MonoBehaviour {

    public static float velocidad = 40f;
    float timer;
    bool enMov;

	// Use this for initialization
	void Start () {
        enMov = true;
	}
	
	// Update is called once per frame
	void Update () {

        timer += Time.deltaTime;

        if (enMov)
        {
            transform.Translate(Vector3.back * velocidad * Time.deltaTime);
        }

        if(enMov == false)
        {
            if (timer >= 5f)
            {
                gameObject.GetComponent<BoxCollider>().isTrigger = true;
                enMov = true;
            }
        }

	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "PosicionFinal")
        {
            timer = 0f;
            enMov = false;
        }
    }
}
