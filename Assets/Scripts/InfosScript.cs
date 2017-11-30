using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfosScript : MonoBehaviour {

	public string Difficulty;
	public int CurrentLife;

	// Use this for initialization
	private void Start () {

		PlayerPrefs.SetInt ("Life", CurrentLife);
		PlayerPrefs.SetString ("Dif", Difficulty);
		PlayerPrefs.SetFloat ("Coucou", 0.1f);

		Debug.Log(PlayerPrefs.GetInt("Life"));
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
