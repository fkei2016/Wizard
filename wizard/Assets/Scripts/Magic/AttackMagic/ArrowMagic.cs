﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowMagic : MagicBase {

    [SerializeField]
    GameObject hit; //ヒットエフェクト

    public override void Initialize(PlayerBase pBase) {
        float speed = 15f;

        //生成したオブジェクトをプレイヤーの向いている方向に飛ばす
        Rigidbody r = this.GetComponent<Rigidbody>();
        //角度を取得
        Vector3 angle = pBase.transform.rotation.eulerAngles * Mathf.Deg2Rad;
        //速度を求める
        Vector3 vel;
        vel.x = Mathf.Cos(angle.y) * speed;
        vel.y = r.velocity.y;
        vel.z = Mathf.Sin(angle.y) * speed * -1;

        r.velocity = vel;
        //自身の角度を変更する
        this.transform.rotation = Quaternion.Euler(pBase.transform.rotation.eulerAngles);
    }


    //終了処理
    public override void Final() {
        //自身を消去
        Destroy(this.gameObject);
        //その場にヒットエフェクトを生成
        GameObject obj = Instantiate(hit, this.transform.position, Quaternion.identity) as GameObject;
        //消滅タイムを設ける
        Destroy(obj, 3f);
    }

}
