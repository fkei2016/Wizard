using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerBase : MonoBehaviour {

    //魔法に関するデータ
    public class MagicData {
        public UnityAction deadlyAction = () => { }; //必殺魔法の処理
        public UnityAction supportAction = () => { }; //補助魔法の処理
        public UnityAction sMagicAction = () => { }; //強魔法の処理
        public UnityAction wMagicAction = () => {}; //弱魔法の処理

        public float deadlyWaitTime = 0; //必殺魔法の待機時間
        public float supportWaitTime = 0; //補助魔法の待機時間
        public  float sMagicWaitTime = 0; //強攻撃の待機時間
        public float wMagicWaitTime = 0; //弱攻撃の待機時間
    }


    [System.NonSerialized]
    public MagicData magicData = new MagicData(); //魔法データ

    [System.NonSerialized]
    int life = 100; //体力 

    public int PlayerID; //プレイヤーのID

    [System.NonSerialized]
    public float moveSpeed = 5; //移動速度
    [System.NonSerialized]
    public float turnaroundSpeed = 3; //方向転換速度

    Rigidbody rigid; //自身の剛体

	// Use this for initialization
	public void Start () {
        rigid = this.GetComponent<Rigidbody>();

        //魔法データを読み込む
        LoadMagic();
	}
	
	//前進
    public void Advance(float mag) {
        //角度を取得
        Vector3 angle = this.transform.rotation.eulerAngles * Mathf.Deg2Rad;
        //速度を求める
        Vector3 vel;
        vel.x = Mathf.Cos(angle.y) * moveSpeed * mag;
        vel.y = rigid.velocity.y;
        vel.z = Mathf.Sin(angle.y) * moveSpeed * (mag * -1);

        rigid.velocity = vel;
    }

    //速度停止
    public void MoveStop() {
        //y速度以外を0に
        Vector3 vel = rigid.velocity;
        vel.x = 0;
        vel.z = 0;
        rigid.velocity = vel;
    }

    //方向転換
    public void Turnaround(float mag) {
        this.transform.Rotate(0, turnaroundSpeed * mag, 0);
    }


    //魔法を読み込む
    void LoadMagic() {
        //リストクラスから魔法を読み込む
        WeakMagicList.LoadWeakMagic(magicData, PlayerID, this);
    }

}
