using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DañoGeneral : MonoBehaviour
{
    public Image[] hitpoints;
    int vida = 5;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (Input.GetKeyDown(KeyCode.J))
        {
            GetHurt();
        }
        */
    }
    
    private void OnCollisionEnter(Collision obj)
    {
        if (obj.gameObject.tag == "Enemigo")
        {
            Destroy(obj.gameObject, 1f);
            GetHurt();
        }

        if (obj.gameObject.tag == "Pildora")
        {
            Destroy(obj.gameObject, 1f);
            recuperarvida();
        }
    }

    void GetHurt()
    {
        if (vida > 0)
        {
            vida = vida - 1;
        }
        hitpoints[vida].gameObject.SetActive(false);
        if (vida == 0)
        {
            SceneManager.LoadScene("Derrota");
        }
    }

    void recuperarvida()
    {
        if (vida > 0)
        {
            vida = vida + 1;
        }
        hitpoints[vida].gameObject.SetActive(true);

    }

}

