﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLife : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision);

    }
    private void OnParticleCollision(GameObject other)
    {
        Debug.Log(other);
    }
}
