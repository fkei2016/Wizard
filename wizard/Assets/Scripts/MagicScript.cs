using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MagicScript : MonoBehaviour {
    [SerializeField, Tooltip("クールタイム")]
    protected int coolDownTime;

    public int m_CoolDownTime
    {
        set
        {
            coolDownTime = value;
        }
        get
        {
            return coolDownTime;
        }
    }

    // Use this for initialization
    void Start () {

    }

    //魔法を発動する
    void Invoke()

    {
    }
}
