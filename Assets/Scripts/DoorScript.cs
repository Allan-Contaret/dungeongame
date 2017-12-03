using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{

	public bool IsOpen = false;
	private Vector3 StartPosition;
	private Vector3 EndPosition;

	//public Color StColor, EndColor, CurrentColor;

	
	private float timer = 0;

	void Start ()
	{
		StartPosition = transform.localPosition;
		EndPosition = StartPosition + new Vector3 (0, 40f, 0);

	}




	private void OnTriggerEnter (Collider other)
	{
		if (other.tag == "Player") {
			IsOpen = true;
			timer = 0;
		}
	}

	private void OnTriggerExit (Collider other)
	{
		if (other.tag == "Player") {
			IsOpen = false;
			timer = 1;
		}
	}
		

	// Update is called once per frame
	void Update ()
	{
		
		if (IsOpen)
			timer += Time.deltaTime;
		else
			timer -= Time.deltaTime;
	
		transform.localPosition = Vector3.Lerp (StartPosition, EndPosition, timer);
	}
}
