using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelScript : MonoBehaviour {

    private float timer = 0;
    private Color Color;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        timer += Time.deltaTime;


        if(timer > 20.5f)
        {

            GetComponent<Image>().color = Color.clear;
        }

        if (!GameObject.FindGameObjectWithTag("Boss"))
        {

            GetComponent<Image>().color = new Color(0, 0, 0, 0.63f);

        }
		
	}
}
