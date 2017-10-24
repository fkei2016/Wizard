﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour {

    PlayerBase pBase; //プレイヤーの基礎クラス

	// Use this for initialization
	void Start () {
        pBase = this.GetComponent<PlayerBase>();
	}
	
	// Update is called once per frame
	void Update () {
        //魔法使用
        CheckUseMagic();
	}

    //攻撃使用
    void CheckUseMagic() {
        //wキー担当
        if(Input.GetAxisRaw("Magic1") != 0 ) {
            if (pBase.magicData.magic1.waitTime > 0) return;
            //待機時間があるか
            pBase.magicData.magic1.action.Invoke();
        }
        //aキー担当
        else if (Input.GetAxisRaw("Magic2") != 0) {
            if (pBase.magicData.magic2.waitTime > 0) return;
            pBase.magicData.magic2.action.Invoke();
        }
        //dキー担当
        else if (Input.GetAxisRaw("Magic3") != 0) {
            if (pBase.magicData.magic3.waitTime > 0) return;
            pBase.magicData.magic3.action.Invoke();
        }
        //sキー担当
        else if (Input.GetAxisRaw("Magic4") != 0) {
            if (pBase.magicData.magic4.waitTime > 0) return;
            pBase.magicData.magic4.action.Invoke();
        }
    }




}
