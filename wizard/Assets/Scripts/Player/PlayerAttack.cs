using System.Collections;
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
        //弱魔法
        if(Input.GetAxisRaw("WeakMagic") != 0) {
            pBase.magicData.wMagicAction.Invoke();
        }
        //強魔法
        //補助魔法
        //必殺魔法
    }




}
