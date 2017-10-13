using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magic_FireBolt : Magic_BasicAttack
{

	// Use this for initialization
	void Start () {
		
	}

    public override void CastSpell()
    {
        Debug.Log("Fire bolt was invoked!");
    }
}
