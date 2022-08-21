using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatManager : MonoBehaviour
{

    //Singleton
    public static CombatManager Instance;

    PokemonProperties pokemonProperties;
    MoveList moveList;

    
    private Dictionary<Pokemon_ID,Pokemon> playerPokemonList = new Dictionary<Pokemon_ID, Pokemon>();
    private Dictionary<Pokemon_ID,Pokemon> enemyPokemonList = new Dictionary<Pokemon_ID, Pokemon>();


    private Pokemon currentPlayerPokemon;
    private Pokemon currentEnemyPokemon;



    private void Awake() {
        //If Singleton (Instance) exists, it deletes it. If not, it initializes it 
        if (Instance != null && Instance != this) {
            Destroy(this);
        } else {
            Instance = this;
        }
    }
    private void Start() {
        
    }

    private void Update() {
        GetInternalPokemons();
    }

    public void pokemonAttack(Pokemon_ID attacker, Move_ID move, Pokemon_ID target) {

        float damage;

        Move playerMove = moveList.moves[move];


    }

    //This is the method that is called when the player selects a move for their pokemon to do.
    //It recieves data of player's, the move it used and data from the enemie's pokemon to calculate damage and apply it
    public void playerAttack(int moveIndex) {

        //We save the move that player's pokemon used in a variable using the moveIndex to make the code easier to read
        Move playerMove = moveList.moves[currentPlayerPokemon.moveSet[moveIndex]];

        //float that will hold the calculated damage
        float damage;

        //We check if the used move is special or not, so we can use the "Attack" and "Defense" stats for the damage formula or "Special Attack" and "Sepcial Defense" stats
        switch (playerMove.SP) {
            case true:
                damage = ((2f * currentPlayerPokemon.level / 5) + 2) * (playerMove.PWR) * (currentPlayerPokemon.sp_Atkk / currentEnemyPokemon.sp_Deff) / 50;
                break;
            
            case false:
                damage = ((2f * currentPlayerPokemon.level / 5) + 2) * (playerMove.PWR) * (currentPlayerPokemon.attack / currentEnemyPokemon.defense) / 50;
                break;

        }
        
        currentEnemyPokemon.HP = currentEnemyPokemon.HP - damage;

    }

    public void enemieAttack() {

    }


    //Adds the pokemon from public list of GameManager to internal dictionary in CombatManager
    private void GetInternalPokemons() {
        /*for (int i = 0; i < GameManager.Instance.playerPokemons.Length - 1; i++) {
            playerPokemonList.Add(pokemonProperties.Pokedex[GameManager.Instance.playerPokemons[i]].id, pokemonProperties.Pokedex[GameManager.Instance.playerPokemons[i]]);
        }
        for (int i = 0; i < GameManager.Instance.enemyPokemons.Length; i++) {
            enemyPokemonList.Add(pokemonProperties.Pokedex[GameManager.Instance.enemyPokemons[i]].id, pokemonProperties.Pokedex[GameManager.Instance.enemyPokemons[i]]);
        }*/

        currentPlayerPokemon = playerPokemonList[GameManager.Instance.currentPlayerPokemon];
        currentEnemyPokemon = playerPokemonList[GameManager.Instance.currentEnemyPokemon];
    }
}
