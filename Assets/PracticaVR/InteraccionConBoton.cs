using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteraccionConBoton : MonoBehaviour {

	public Material materialActivo, materialInactivo;

	// Use this for initialization
	void Start () {

		GetComponent<Renderer> ().material = materialInactivo;
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	public void activa(bool activado){

		if (activado) {
			GetComponent<Renderer> ().material = materialActivo;
			Debug.Log ("Activado");
		} 

		else {
			GetComponent<Renderer> ().material = materialInactivo;
			Debug.Log ("Desactivado");
		}
	}

	public void interaccion(){
 
		//generamos una posición aleatoria en una esfera envolvente de radio 1
		Vector3 nuevaPosicion = Random.onUnitSphere;
		
        //lo alejamos una distancia de nosotros
		float distancia = 3 * Random.value + 3f;
        nuevaPosicion *= distancia;

        //restringimos la altura
        nuevaPosicion.y = Random.Range(0f, 1.5f);

        //asignamos la posicion
        transform.localPosition = nuevaPosicion;

        Debug.Log("Interaccion");
    }

}
