﻿using UnityEngine;
using System.Collections;

public class bush : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnBecameInvisible()
    {
        gameObject.SetActive(false);
    }
}
