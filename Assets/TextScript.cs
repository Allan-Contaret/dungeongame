using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextScript : MonoBehaviour {

	private void OnTriggerEnter(Collider c){
		
		if(c.tag == "Player")
		GetComponent<TextMesh> ().color = new Color(1, 1, 1);	

	}

	private void OnTriggerExit(Collider c){
		if(c.tag == "Player")

	GetComponent<TextMesh> ().color = new Color(0, 0, 0);

	}
}
