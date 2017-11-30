using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisonScript : MonoBehaviour {

	void OnCollisionEnter(Collision c){

		c.gameObject.transform.localScale = new Vector3 (2, 2, 2);

	}
}
