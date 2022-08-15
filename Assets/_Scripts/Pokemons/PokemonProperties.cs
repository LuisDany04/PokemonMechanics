using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PokemonProperties : MonoBehaviour {



    //Main Dictionary
    public Dictionary<Pokemon_ID, Pokemon> Pokedex = new Dictionary<Pokemon_ID, Pokemon>();


    //Items, Moves, etc Dictionaries

    //References to other scripts
    MoveList Moves;

    private void Start() {
        PokemonData();;
    }



    //Function that adds de Pokemon data to our dictionary called "Pokedex" with all it's stats.
    private void PokemonData() {

        Pokedex.Add(Pokemon_ID.CHARIZARD, new Pokemon {  //Fill the properties of each Pokemon with the desired data.
            name="CHARIZARD", 
            level=                          50, 
            HP=HP_Formula                   (78, 50),    //Final stat gets calculated with the given data (Check method "HP_Formula" and "Stat_Formula).   
            attack=Stat_Formula             (84, 50), 
            defense=Stat_Formula            (78, 50), 
            sp_Atkk=Stat_Formula            (109, 50), 
            sp_Deff=Stat_Formula            (85, 50), 
            speed=Stat_Formula              (100, 50), 

            moveSet = new Move_ID[]
            {
                Move_ID.TACKLE,
                Move_ID.BURN,
                Move_ID.GROWL,
                Move_ID.QUICK_ATTACK

            }
        });

        Pokedex.Add(Pokemon_ID.BLASTOISE, new Pokemon {
            name="BLASTOISE",
            level =                         50, 
            HP=HP_Formula                   (79, 50), 
            attack=Stat_Formula             (103, 50), 
            defense=Stat_Formula            (120, 50), 
            sp_Atkk=Stat_Formula            (135, 50), 
            sp_Deff=Stat_Formula            (115, 50), 
            speed=Stat_Formula              (78, 50), 
            moveSet = new Move_ID[]
            {
                Move_ID.TACKLE,
                Move_ID.HYDRO_CANNON,
                Move_ID.GROWL,
                Move_ID.QUICK_ATTACK

            }
        });

        Pokedex.Add(Pokemon_ID.VENUSAUR, new Pokemon {
            name = "VENUSAUR",
            level =                         50,
            HP = HP_Formula                 (80, 50),
            attack = Stat_Formula           (82, 50),
            defense = Stat_Formula          (83, 50),
            sp_Atkk = Stat_Formula          (100, 50),
            sp_Deff = Stat_Formula          (100, 50),
            speed = Stat_Formula            (80, 50),
            moveSet = new Move_ID[]
            {
                Move_ID.TACKLE,
                Move_ID.VINE_WHIP,
                Move_ID.GROWL,
                Move_ID.QUICK_ATTACK

            }
        });

        Pokedex.Add(Pokemon_ID.PIKACHU, new Pokemon {
            name = "PIKACHU",
            level =                         50,
            HP = HP_Formula                 (45, 50),
            attack = Stat_Formula           (80, 50),
            defense = Stat_Formula          (50, 50),
            sp_Atkk = Stat_Formula          (75, 50),
            sp_Deff = Stat_Formula          (60, 50),
            speed = Stat_Formula            (120, 50),
            moveSet = new Move_ID[]
            {
                Move_ID.TACKLE,
                Move_ID.THUNDERBOLT,
                Move_ID.GROWL,
                Move_ID.QUICK_ATTACK

            }
        });

        Pokedex.Add(Pokemon_ID.GENGAR, new Pokemon {
            name = "GENGAR",
            level =                         50,
            HP = HP_Formula                 (60, 50),
            attack = Stat_Formula           (65, 50),
            defense = Stat_Formula          (60, 50),
            sp_Atkk = Stat_Formula          (130, 50),
            sp_Deff = Stat_Formula          (75, 50),
            speed = Stat_Formula            (110, 50),
            moveSet = new Move_ID[]
            {
                Move_ID.TACKLE,
                Move_ID.HYDRO_CANNON,
                Move_ID.GROWL,
                Move_ID.EMPTY

            }
        });




    }

    //HP formula from the PokemonWiki, but simplified. First parameter refers to the base stat and second one is the pokemon level.
    private int HP_Formula(int baseStat, int level) {
        return Mathf.RoundToInt(Mathf.Floor(0.01f * (2 * baseStat * level) + level + 10));    
    }

    //Stat formula from the PokemonWiki, but simplified. First parameter refers to the base stat and second one is the pokemon level.
    private int Stat_Formula(int baseStat, int level) {
        return Mathf.RoundToInt(Mathf.Floor(0.01f * (2 * baseStat * level) + 5));
    }
}
