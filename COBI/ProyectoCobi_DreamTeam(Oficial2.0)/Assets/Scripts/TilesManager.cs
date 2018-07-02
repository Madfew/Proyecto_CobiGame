using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TilesManager : MonoBehaviour {

    float velocidad = 25f;

    void Start()
    {

    }

    void Update()
    {
        transform.Translate(Vector3.back * velocidad * Time.deltaTime);
    }
}
