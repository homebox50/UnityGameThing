﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeMovement2 : MonoBehaviour {

    public float speed;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.Translate(-speed * Time.deltaTime, 0, 0, Camera.main.transform);
    }
}
