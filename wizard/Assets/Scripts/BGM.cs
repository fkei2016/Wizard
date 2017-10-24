using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM : MonoBehaviour {

	// Use this for initialization
	void Start () {

        AudioManager.Instance.ChangeVolume(0.2f, 1.0f);
        AudioManager.Instance.PlayBGM("Title_BGM");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
