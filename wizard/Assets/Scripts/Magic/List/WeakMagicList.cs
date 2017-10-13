/************
 * 
 * アタッチ禁止
 * 
 ***********/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeakMagicList : MonoBehaviour {

    //弱魔法を読み込む
    public static void LoadWeakMagic(PlayerBase.MagicData magic, int id, PlayerBase pBase) {
        //どのプレイヤーの魔法を読み込むか
        int weakMagicID = PlayerPrefs.GetInt(SaveDataKey.PLAYER_WEAKMAGIC_KEY + id.ToString(), 0);

        //魔法データを取得する
        switch (weakMagicID) {
            //デバッグ用弱魔法
            case 0:
                print("デバッグ用弱魔法です");
                magic.wMagicAction = () => {
                    GameObject res = Resources.Load("Magic/WeakMagic/TestMagic") as GameObject;
                    GameObject obj = Instantiate(res, pBase.transform.position, Quaternion.identity) as GameObject;
                    //生成したオブジェクトを向いている方向に飛ばす
                    Rigidbody r = obj.GetComponent<Rigidbody>();
                    //角度を取得
                    Vector3 angle = pBase.transform.rotation.eulerAngles * Mathf.Deg2Rad;
                    //速度を求める
                    Vector3 vel;
                    vel.x = Mathf.Cos(angle.y) * 10;
                    vel.y = r.velocity.y;
                    vel.z = Mathf.Sin(angle.y) * 10 * -1;

                    r.velocity = vel;
                };
                break;
        }
    }
	
}
