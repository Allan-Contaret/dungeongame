﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SpiderScript : LifeScript
{
	private NavMeshAgent agent;
	public Transform Destination;
	public LifeBarScript life;

	private void Update ()
	{
		
		agent.destination = Destination.position;

	}

	private void Start(){

		agent = GetComponent<NavMeshAgent> ();

		life.PvMax = Pv;

	}

	public override void Damage (int d)
	{
		base.Damage (d);
		GetComponent<Animator>().SetInteger ("pv", Pv);
		if (Pv <= 0) {

			GetComponent<NavMeshAgent>().enabled = false;
			Destroy (this);
			gameObject.tag = "Untagged";
		}
		life.Damage (d);
	}
}