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

        Vector3 target = transform.position + 
            (destino.transform.position - transform.position) * speed * Time.deltaTime;

        // newPosition = Vector3.MoveTowards(transform.position, 
        //     target, Time.deltaTime * speed);

        // transform.Translate(destino.transform.position * speed);
        transform.position = target;


    }
    public void empezar()
    {
        IU.SetActive(false);
        speed = 200f;
    }
   
}
