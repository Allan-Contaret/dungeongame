using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SpiderScript : LifeScript
{
	private NavMeshAgent agent;
	public Transform Destination;

	private void Update ()
	{
		
		agent.destination = Destination.position;

	}

	private void Start(){

		agent = GetComponent<NavMeshAgent> ();

	}

	public override void Damage (int d)
	{
		base.Damage (d);
		GetComponent<Animator>().SetInteger ("pv", Pv);
		if (Pv <= 0) {

			GetComponent<BoxCollider>().enabled = false;
			GetComponent<NavMeshAgent>().enabled = false;
			Destroy (this);
		}
	}
}