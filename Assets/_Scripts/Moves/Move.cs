using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move
{
    //"Move" Object with all needed properties

    public string name;
    public MoveCategory_ID category;
    public Type_ID type;
    public int PWR; //POWER
    public int ACC; //Accuaracy 
    public int PP;  //How many PP does it cost using this move
    public bool SP; //Is it a special move?
    public bool EFC; //Does the move has any chance to cause an effect? 
    public bool EFC_StealTurn; //Does the effect makes the target pokemon skip turn?
    public string EFC_Text; //What will be the text shown when the effect is applied?
    public int EFC_TIME; //How many turns will the effect last?
    public Effect_ID EFC_ID;


    


}
