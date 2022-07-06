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
        pokemonData();
        gameObject.GetComponent<MoveList>();
    }



    //Function that adds de Pokemon data to our dictionary called "Pokedex"
    private void pokemonData() {

        Pokedex.Add(Pokemon_ID.CHARIZARD, new Pokemon {name="CHARIZARD", moveSet = new Move_ID[]
        {
            Move_ID.TACKLE,
            Move_ID.BURN,
            Move_ID.GROWL,
            Move_ID.QUICK_ATTACK

        }
        });

        Pokedex.Add(Pokemon_ID.BLASTOISE, new Pokemon {name="BLASTOISE", moveSet = new Move_ID[]
        {
            Move_ID.TACKLE,
            Move_ID.HYDRO_CANNON,
            Move_ID.GROWL,
            Move_ID.QUICK_ATTACK

        }
        });

        Pokedex.Add(Pokemon_ID.VENUSAUR, new Pokemon {name="VENUSAUR", moveSet = new Move_ID[]
        {
            Move_ID.TACKLE,
            Move_ID.VINE_WHIP,
            Move_ID.GROWL,
            Move_ID.QUICK_ATTACK

        }
        });

        Pokedex.Add(Pokemon_ID.PIKACHU, new Pokemon {name="PIKACHU", moveSet = new Move_ID[]
        {
            Move_ID.TACKLE,
            Move_ID.THUNDERBOLT,
            Move_ID.QUICK_ATTACK,
            Move_ID.EMPTY

        }
        });

        Pokedex.Add(Pokemon_ID.GENGAR, new Pokemon {name="GENGAR", moveSet = new Move_ID[]
        {
            Move_ID.TACKLE,
            Move_ID.SHADOWBALL,
            Move_ID.GROWL,
            Move_ID.EMPTY

        }
        });


    }
}
