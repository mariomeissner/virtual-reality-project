using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
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
	if(collisionInfo.collider.name=="Terrain"){
	    Application.LoadLevel(Application.loadedLevel);    
        } else if(collisionInfo.collider.tag=="PickUp"){
	    this.transform.parent.GetComponent<VueloController>().speed *= 2; 
        }
    }
}
