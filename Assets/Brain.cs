﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brain : MonoBehaviour {

	public void handleKneeActionEvent ()
	{
		this.transform.GetChild (0).gameObject.GetComponent <MeshRenderer> ().material.color = new Color (1, 0, 0);
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}