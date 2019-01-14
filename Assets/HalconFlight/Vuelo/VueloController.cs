using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VueloController : MonoBehaviour {
    public GameObject IU;
    public GameObject destino;
    public float speed = 0f;
    private Vector3 newPosition;

    // Use this for initialization
    void Start () {
        newPosition = transform.position;
        
    }


    private void Update()
    {

        Vector3 target = destino.transform.position + 
            (destino.transform.position - transform.position) * speed;

        newPosition = Vector3.MoveTowards(transform.position, 
            target, Time.deltaTime * speed);
        transform.position = newPosition;


    }
    public void empezar()
    {
        IU.SetActive(false);
        speed = 05f;
    }
   
}
