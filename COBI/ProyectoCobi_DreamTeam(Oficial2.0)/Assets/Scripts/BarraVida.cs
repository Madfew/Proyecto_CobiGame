using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraVida : MonoBehaviour {

    public Image barraVida;

    float hp, mxHp = 100f;

	// Use this for initialization
	void Start () {
        hp = mxHp;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Daño(float valorDaño)
    {
        hp = Mathf.Clamp(hp - valorDaño, 0f, mxHp);
        barraVida.transform.localScale = new Vector2(hp / mxHp, 1);
    }
}
