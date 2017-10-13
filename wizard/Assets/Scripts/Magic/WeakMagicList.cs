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
    public static void LoadWeakMagic(PlayerBase.MagicData magic, int id) {
        //どのプレイヤーの魔法を読み込むか
        int weakMagicID = PlayerPrefs.GetInt(SaveDataKey.PLAYER_WEAKMAGIC_KEY + id.ToString(), 0);

        //魔法データを取得する
        switch (weakMagicID) {
            //デバッグ用弱魔法
            case 0:
                print("デバッグ用弱魔法です");
                magic.wMagicAction = () => {
                    print("TTTTTTTTTTTTEEEEST");
                };
                break;
        }
    }
	
}
