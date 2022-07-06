using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveList: MonoBehaviour
{

    //Main Dictionary
    public Dictionary<Move_ID, Move> moveList;

    private void movesData() {
        moveList.Add(Move_ID.EMPTY, new Move("", Type_ID.NORMAL, 0, 0, 0, true));
        moveList.Add(Move_ID.TACKLE, new Move("TACKLE", Type_ID.NORMAL, 0, 0, 0, false));
        moveList.Add(Move_ID.BURN, new Move("BURN", Type_ID.FIRE, 0, 0, 0, true));
        moveList.Add(Move_ID.THUNDERBOLT, new Move("THUNDERBOLT", Type_ID.ELECTRIC, 0, 0, 0, true));
    }


}
