﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class camera : MonoBehaviour
{

    private int count;
    private int lastCount = 0;
    public Text cornerText;
    public Text menuText;

    public counter counter;

    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        print("Setting counter text, last count: " + counter.prevPoints.ToString());
        SetCounterText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag=="Terrain"){
            Application.LoadLevel(Application.loadedLevel);
            lastCount = count;
            counter.prevPoints = counter.points;
            SetCounterText();
        } else if(collisionInfo.collider.tag=="PickUp"){
            this.transform.parent.GetComponent<VueloController>().speed += 1; 
            count += 1;
            counter.points += 1;
            SetCounterText();
        }
    }
    void SetCounterText(){
        cornerText.text = "Points: " + count.ToString();
        print(lastCount.ToString());
        menuText.text = "Points: " + lastCount.ToString();
    }
}
