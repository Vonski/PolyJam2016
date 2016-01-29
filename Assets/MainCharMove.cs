﻿using UnityEngine;
using System.Collections;

public class MainCharMove : MonoBehaviour {

    public float speed = 2;

	// Use this for initialization
	void Start () 
    {
	    
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
            Camera.main.transform.position += Vector3.right * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
            Camera.main.transform.position += Vector3.left * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += Vector3.up * speed * Time.deltaTime;
            transform.position += Vector3.forward * speed * Time.deltaTime;
            
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += Vector3.down* speed * Time.deltaTime;
            transform.position += Vector3.back * speed * Time.deltaTime;

        }
	}
}
