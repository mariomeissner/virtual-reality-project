using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    public GameObject IU;
    public GameObject pajaro;
	public void reiniciar(){
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
	}

	public void salir(){
		Application.Quit ();
	}
    public void empezar()
    {
        IU.SetActive(false);
    }

}
