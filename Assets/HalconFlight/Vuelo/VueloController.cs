using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VueloController : MonoBehaviour {

    public GameObject destino;
    public float speed = 10f;
    private Vector3 newPosition;

    // Use this for initialization
    void Start () {
        newPosition = transform.position;
        
    }


    private void Update()
    {
        newPosition = Vector3.MoveTowards(transform.position, destino.transform.position, Time.deltaTime * speed);
        transform.position = newPosition;

    }

}