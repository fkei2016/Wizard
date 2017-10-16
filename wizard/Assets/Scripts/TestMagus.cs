using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMagus : MonoBehaviour {
    private const int maximumSlotNum = 4;

    [SerializeField]
    public MagicScript[] magic;

    // Use this for initialization
    void Start () {

        Debug.Log("s");
    }
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown("a"))
        {
            magic[0].CastSpell();
        }

	}
}
