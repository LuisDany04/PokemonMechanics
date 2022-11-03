using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pokemon {

    //Properties
    public Pokemon_ID id;
    public string name;
    public int level;
    public float actualHP;
    public float maxHP;
    public int attack;
    public int defense;
    public int sp_Atkk;
    public int sp_Deff;
    public int speed;
    public Type_ID type;
    public Ability_ID ability;
    public Move[] moveSet;
    public Effect_ID effect = Effect_ID.NO_EFFECT;
    public int effectTimer = 0;
}

