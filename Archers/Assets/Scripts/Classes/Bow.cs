﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bow : Item {
	public string bowType;
	public float speedModifier;
	public float rangeModifier;

    // Texture
    public Sprite itemSprite;
	
	void Start () {
		itemName = "Bow";
	}
	
	void Update () {
		
	}
}
