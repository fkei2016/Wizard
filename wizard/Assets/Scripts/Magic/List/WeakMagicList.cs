/************
 * 
 * アタッチ禁止
 * 
 ***********/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeakMagicList : MonoBehaviour {

    //魔法を読み込む
    //1~99:攻撃魔法  100~補助魔法
    public static void LoadMagic(PlayerBase.Magic magic, int magicID, PlayerBase pBase) {

        //魔法データを取得する
        switch (magicID) {
            //デバッグ用弱魔法
            case 0:
                magic.action = () => {
                    GameObject obj = CreateMagic("Magic/TestMagic", magic, pBase);
                    obj.GetComponent<MagicBase>().Initialize(pBase);
                };
                break;
            //ファイアボルト
            case 1:
                magic.action = () => {
                    GameObject obj = CreateMagic("Magic/FireBolt", magic, pBase);
                    obj.GetComponent<MagicBase>().Initialize(pBase);
                };
                break;
            //アロー
            case 2:
                magic.action = () => {
                    GameObject obj = CreateMagic("Magic/Arrow", magic, pBase);
                    obj.GetComponent<MagicBase>().Initialize(pBase);
                };
                break;
            //エラー
            default:
                print("ERRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRROOOOR");
                break;
        }
    }



    //魔法を生成し基礎情報を登録後オブジェクトを返す
    static GameObject CreateMagic(string path, PlayerState.Magic magic, PlayerBase pBase) {
        GameObject res = Resources.Load(path) as GameObject;
        GameObject obj = Instantiate(res, pBase.transform.position, Quaternion.identity) as GameObject;


        //消滅時間を設ける
        Destroy(obj, obj.GetComponent<MagicBase>().destroyTime);
        //クールタイムを設ける
        magic.waitTime = obj.GetComponent<MagicBase>().waitTime;
        //自信を登録させる
        obj.GetComponent<MagicBase>().self = pBase.gameObject;

        return obj;
    }
    
	
}
