using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMagus : MonoBehaviour {
    private const int maximumSlotNum = 4;

    [SerializeField]
    public MagicScript[] magic;

    public GaugeControler ui;

    private float maximumCoolTime;
    private float coolTime;
    // Use this for initialization
    void Start () {

        Debug.Log("s");
        maximumCoolTime = 1.0f;
        coolTime = 0;
    }
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown("a") && coolTime <= 0)
        {
            coolTime = maximumCoolTime;
            magic[0].CastSpell();
        }
        ui.setValue(maximumCoolTime, maximumCoolTime - coolTime);

        coolTime-= 0.1f;

        coolTime = Mathf.Clamp(coolTime, 0, maximumCoolTime);

    }
}
