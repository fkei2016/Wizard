using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

    PlayerBase pBase; //プレイヤーの基礎クラス

	// Use this for initialization
	void Start () {
        pBase = this.GetComponent<PlayerBase>();
	}
	
	// Update is called once per frame
	void Update () {
        //移動
        Move();
        //方向転換
        Turnaround(); 
	}

    //移動処理
    void Move() {
        //前進キーが押されているか
        if (Input.GetAxisRaw("Vertical") != 0) {
            //向いている方向に前進
            pBase.Advance(Input.GetAxisRaw("Vertical") * pBase.speedMag);
        }
        //前進キーが押されていない
        else {
            pBase.MoveStop();
        }
    }


    //方向転換
    void Turnaround() {
        //転換キーが押されているか
        if (Input.GetAxisRaw("Horizontal") != 0) {
            //方向転換
            pBase.Turnaround(Input.GetAxisRaw("Horizontal"));
        }
    }

}
