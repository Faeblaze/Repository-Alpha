﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{
    public float rotationsPerSecond = .1f;
    public bool _;
    public int levelShown = 0;
		
	// Update is called once per frame
	void Update ()
    {
        //Read the current shield level from the Hero Singleton
        int currLevel = Mathf.FloorToInt(Hero.S.shieldLevel);
        // If this different from levelShown...
        if (levelShown != currLevel)
        { levelShown = currLevel;
            Material mat = GetComponent<Renderer>().material;
            //Adjust the texture offset to show different shield level
            mat.mainTextureOffset = new Vector2(0.2f * levelShown, 0);
        }
        //Rotate the shield a bit every second
        float rZ = (rotationsPerSecond * Time.time * 360) % 360f;
        transform.rotation = Quaternion.Euler(0, 0, rZ);
	}
}
