using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup : MonoBehaviour
{

    public AudioClip pickupSound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collisionInfo)
    {
        AudioSource.PlayClipAtPoint(pickupSound, transform.position);
        
        //generamos una posición aleatoria en una esfera envolvente de radio 1
        Vector3 nuevaPosicion = Random.onUnitSphere;

        //lo alejamos una distancia de nosotros
        float distancia = 100 * Random.value + 3f;
        nuevaPosicion *= distancia;

        //restringimos la altura
        //nuevaPosicion.y = Random.Range(0f, 1.5f);

        //asignamos la posicion
        transform.localPosition = nuevaPosicion;

        Debug.Log("Interaccion");
    }
}
