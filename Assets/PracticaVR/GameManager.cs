using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public void reiniciar(){
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
	}

	public void salir(){
		Application.Quit ();
	}
  
}
