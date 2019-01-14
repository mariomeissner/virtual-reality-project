using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class camera : MonoBehaviour
{

    private int count;
    private int lastCount = 0;
    public Text cornerText;
    public Text menuText;
    public AudioClip hitSound;

    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        print("Setting counter text, last count: " + count.ToString());
        SetCounterText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag=="Terrain"){
            AudioSource.PlayClipAtPoint(hitSound, transform.position);
            Application.LoadLevel(Application.loadedLevel);
            lastCount = count;
            SetCounterText();
        } else if(collisionInfo.collider.tag=="PickUp"){
            this.transform.parent.GetComponent<VueloController>().speed += 2; 
            count += 1;
            SetCounterText();
        }
    }
    void SetCounterText(){
        cornerText.text = "Points: " + count.ToString();
        print(lastCount.ToString());
        menuText.text = "Points: " + lastCount.ToString();
    }
}
