using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextScript : MonoBehaviour {

    private Text t;
    private float timer = 0;

	// Use this for initialization
	void Start () {

        t = GetComponent<Text>();
		
	}
	
	// Update is called once per frame
	void Update () {

        timer += Time.deltaTime;

        if(timer < 10)
        {

            t.text = "Bienvenue dans ce jeu de type Donjon. Pour avancer et vous déplacer vous pouvez utiliser les touches Z, Q, S, D. Vous pouvez également tirer à l'aide du clic gauche de la souris.";

        }else if(timer > 10 && timer < 20)
        {

            t.text = "Le but de ce jeu est d'arriver et combattre le boss final. Mais attention aux embuches sur le chemin. Bon jeu!";

        }
        else if (!GameObject.FindGameObjectWithTag("Boss"))
        {

            t.text = "Félicitations vous avez survécu! Vous avez vaincu le boss final!!!!";

        }
        else
        {

            t.text = "";

        }


    }
}
