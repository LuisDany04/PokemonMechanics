using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveList: MonoBehaviour
{

    //Main Dictionary
    public Dictionary<Move_ID, Move> moves;

    private void movesData() {
        moves.Add(Move_ID.TACKLE, new Move { 
            name = "TACKLE", 
            type = Type_ID.NORMAL,
            PWR = 100,
            ACC = 100,
            PP = 100,
            EFC = false
        });
    }


}
