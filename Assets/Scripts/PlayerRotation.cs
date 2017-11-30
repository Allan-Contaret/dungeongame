﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation : MonoBehaviour {

	public Transform CamTransform;
	public float SpeedRotation;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		float x = Input.GetAxis ("Mouse Y");
		float y = Input.GetAxis ("Mouse X");




		transform.eulerAngles += new Vector3 (0, y, 0) * SpeedRotation;
		CamTransform.eulerAngles += new Vector3 (-x, 0, 0) * SpeedRotation;
		
	}
}
