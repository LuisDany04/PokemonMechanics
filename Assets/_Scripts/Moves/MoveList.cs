using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveList: MonoBehaviour
{

    //Main Dictionary
    public Dictionary<Move_ID, Move> moves = new Dictionary<Move_ID, Move>();

    private void Awake() {
       movesData();
    }

    private void Start() {
        
    }

    private void movesData() {
        moves.Add(Move_ID.EMPTY, new Move { 
            name = "EMPTY", 
            type = Type_ID.NORMAL,
            PWR = 0,
            ACC = 0,
            PP = 0,
            EFC = false
        });

        moves.Add(Move_ID.TACKLE, new Move {
            name = "TACKLE",
            type = Type_ID.NORMAL,
            PWR = 100,
            ACC = 100,
            PP = 100,
            EFC = false
        });

        moves.Add(Move_ID.GROWL, new Move {
            name = "GROWL",
            type = Type_ID.NORMAL,
            PWR = 100,
            ACC = 100,
            PP = 100,
            EFC = false
        });

        moves.Add(Move_ID.QUICK_ATTACK, new Move {
            name = "QUICK ATTACK",
            type = Type_ID.NORMAL,
            PWR = 100,
            ACC = 100,
            PP = 100,
            EFC = false
        });

        moves.Add(Move_ID.BURN, new Move {
            name = "BURN",
            type = Type_ID.NORMAL,
            PWR = 100,
            ACC = 100,
            PP = 100,
            EFC = false
        });

        moves.Add(Move_ID.HYDRO_CANNON, new Move {
            name = "HYDRO CANNON",
            type = Type_ID.NORMAL,
            PWR = 100,
            ACC = 100,
            PP = 100,
            EFC = false
        });

        moves.Add(Move_ID.VINE_WHIP, new Move {
            name = "VINE WHIP",
            type = Type_ID.NORMAL,
            PWR = 100,
            ACC = 100,
            PP = 100,
            EFC = false
        });

        moves.Add(Move_ID.THUNDERBOLT, new Move {
            name = "THUNDERBOLT",
            type = Type_ID.NORMAL,
            PWR = 100,
            ACC = 100,
            PP = 100,
            EFC = false
        });

        moves.Add(Move_ID.SHADOWBALL, new Move {
            name = "SHADOWBALL",
            type = Type_ID.NORMAL,
            PWR = 100,
            ACC = 100,
            PP = 100,
            EFC = false
        });
    }


}
