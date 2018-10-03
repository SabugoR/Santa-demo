﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    [SerializeField] ZomBunnySpawner bunnySpawner;
    [SerializeField] ZomBearSpawner bearSpawner;
    [SerializeField] HellephantSpawner elephantSpawner;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void HitEnemy(string name)
    {
        Debug.Log("HitEnemy " + name);
        if (name.Contains("Bunny"))
            bunnySpawner.Hit(name);
        if (name.Contains("Bear"))
            bearSpawner.Hit(name);
        if (name.Contains("Hellephant"))
            elephantSpawner.Hit(name);
    }
}
