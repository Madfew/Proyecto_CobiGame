using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreacionProcedural : MonoBehaviour {

    public GameObject[] tiles;
    public int[] orden1;
    public int[] orden2;
    public int[] orden3;
    public int[] orden4;

    private Vector3 puntoInicio;

	// Use this for initialization
	void Start () {
        CreacionTileNivel();
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    public void CreacionTileNivel()
    {
        for (int i = 0; i < orden1.Length; i++)
        {
            GameObject tile = Instantiate(tiles[orden1[i]], puntoInicio, Quaternion.identity);
            puntoInicio = tile.transform.Find("Helper").position;
        }

        for (int i = 0; i < orden2.Length; i++)
        {
            GameObject tile = Instantiate(tiles[orden2[i]], puntoInicio, Quaternion.identity);
            puntoInicio = tile.transform.Find("Helper").position;
        }

        for (int i = 0; i < orden3.Length; i++)
        {
            GameObject tile = Instantiate(tiles[orden3[i]], puntoInicio, Quaternion.identity);
            puntoInicio = tile.transform.Find("Helper").position;
        }

        for (int i = 0; i < orden4.Length; i++)
        {
            GameObject tile = Instantiate(tiles[orden4[i]], puntoInicio, Quaternion.identity);
            puntoInicio = tile.transform.Find("Helper").position;
        }
    }

}
