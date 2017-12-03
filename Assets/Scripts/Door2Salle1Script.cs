using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door2Salle1Script : LifeScript {

	public Vector3 StartPosition;
	private Vector3 EndPosition;

	void Start(){

		EndPosition = StartPosition + new Vector3 (0, 40f, 0); 

	}


	// Update is called once per frame
	void Update () {

		if (GameObject.FindGameObjectWithTag("Spider"))
			
			transform.localPosition = StartPosition;
		else

			transform.localPosition = Vector3.Lerp(StartPosition, EndPosition, 1);
			
			
		
	}
}
