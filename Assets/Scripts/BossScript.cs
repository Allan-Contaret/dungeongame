using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BossScript : LifeScript
{

    public LifeBarScript life;

    private void Update()
    {

        

    }

    private void Start()
    {


        life.PvMax = Pv;

    }

    public override void Damage(int d)
    {
        base.Damage(d);
        GetComponent<Animator>().SetInteger("pv", Pv);
        if (Pv <= 0)
        {
            gameObject.tag = "Untagged";
            Destroy(this);
        }
        life.Damage(d);
    }
}