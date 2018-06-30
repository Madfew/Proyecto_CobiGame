using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menupausa : MonoBehaviour {

     

	public void juegopausa()
    {
     
            Time.timeScale = 0;
    }
    public void juegocontinuar()
    {
        
        
            Time.timeScale = 1;
    }
}


