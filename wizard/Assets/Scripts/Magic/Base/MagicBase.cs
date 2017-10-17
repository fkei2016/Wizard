using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicBase : MonoBehaviour {

    public int damage; //ダメージ量
    public float destroyTime; //消滅時間
    public float waitTime; //待機時間


    [System.NonSerialized]
    public GameObject self = null; //発射元のオブジェクト

	// Use this for initialization
	public virtual void Start () {
        
	}
	
	// Update is called once per frame
	public virtual void Update () {
		
	}

    public virtual void Initialize(PlayerBase pBase) {

    }

    public virtual void OnTriggerEnter(Collider col) {
        //ぶつかったのはブロックか
        if (col.tag == "Block") Final();
        //敵にぶつかった
        if(col.tag == "Player" && col.gameObject != self) {
            //ダメージを与える
            col.GetComponent<PlayerBase>().Damage(damage);
            //最終処理を行う
            Final();
        }
        
    }


    //終了処理
    public virtual void Final() {
        //自身を消去
        Destroy(this.gameObject);
    }

}
