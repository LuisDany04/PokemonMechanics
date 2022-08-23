using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveList: MonoBehaviour
{

    //Main Dictionary
    public Dictionary<Move_ID, Move> moves = new Dictionary<Move_ID, Move>();

    private void Awake() {
        FillMoveDictionary();
    }

    private void Start() {
        
    }

    private void FillMoveDictionary() {
        Debug.Log("Rellenando diccionario de moves");
        moves.Add(Move_ID.EMPTY, new Move { 
            name = "EMPTY", 
            category = MoveCategory_ID.STATUS,
            type = Type_ID.NORMAL,
            PWR = 0,
            ACC = 0,
            PP = 0,
            EFC = false
        });

        moves.Add(Move_ID.TACKLE, new Move {
            name = "TACKLE",
            category = MoveCategory_ID.PHYSICAL,
            type = Type_ID.NORMAL,
            PWR = 40,
            ACC = 100,
            PP = 35,
            EFC = false
        });

        moves.Add(Move_ID.GROWL, new Move {
            name = "GROWL",
            category = MoveCategory_ID.STATUS,
            type = Type_ID.NORMAL,
            PWR = 100,
            ACC = 100,
            PP = 100,
            EFC = false
        });

        moves.Add(Move_ID.QUICK_ATTACK, new Move {
            name = "QUICK ATTACK",
            category = MoveCategory_ID.PHYSICAL,
            type = Type_ID.NORMAL,
            PWR = 40,
            ACC = 100,
            PP = 30,
            EFC = false
        });

        moves.Add(Move_ID.FLAMETHROWER, new Move {
            category = MoveCategory_ID.SPECIAL,
            name = "FLAMETHROWER",
            type = Type_ID.NORMAL,
            PWR = 90,
            ACC = 100,
            PP = 15,
            EFC = false
        });

        moves.Add(Move_ID.HYDRO_CANNON, new Move {
            name = "HYDRO CANNON",
            category = MoveCategory_ID.SPECIAL,
            type = Type_ID.NORMAL,
            PWR = 150,
            ACC = 90,
            PP = 5,
            EFC = false
        });

        moves.Add(Move_ID.VINE_WHIP, new Move {
            name = "VINE WHIP",
            category = MoveCategory_ID.SPECIAL,
            type = Type_ID.NORMAL,
            PWR = 45,
            ACC = 100,
            PP = 25,
            EFC = false
        });

        moves.Add(Move_ID.THUNDERBOLT, new Move {
            name = "THUNDERBOLT",
            category = MoveCategory_ID.SPECIAL,
            type = Type_ID.NORMAL,
            PWR = 90,
            ACC = 100,
            PP = 15,
            EFC = false
        });

        moves.Add(Move_ID.SHADOWBALL, new Move {
            name = "SHADOWBALL",
            category = MoveCategory_ID.SPECIAL,
            type = Type_ID.NORMAL,
            PWR = 80,
            ACC = 100,
            PP = 15,
            EFC = false
        });
    }


}
