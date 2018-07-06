using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DañoGeneral : MonoBehaviour
{
    public Image[] hitpoints;
    int vida = 5;

    void Update()
    {

    }
    
    private void OnTriggerEnter(Collider obj)
    {
         if (obj.gameObject.tag == "Enemigo")
        {
            Destroy(obj.gameObject, 2f);
            GetHurt();
        }
        if (obj.gameObject.tag == "Pildora")
        {
            Destroy(obj.gameObject);
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
        if (vida < 5)
        {
            vida = vida + 1;
        }
        hitpoints[vida - 1].gameObject.SetActive(true);

    }
}


