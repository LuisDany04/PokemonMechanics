using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CombatManager : MonoBehaviour
{

    //Singleton
    public static CombatManager Instance;

    PokemonProperties pokemonProperties;
    MoveList moveList;

    private List<Pokemon> internalPokemonList = new List<Pokemon>();

    private Dictionary<Pokemon_ID,Pokemon> playerPokemonList = new Dictionary<Pokemon_ID, Pokemon>();
    private Dictionary<Pokemon_ID,Pokemon> enemyPokemonList = new Dictionary<Pokemon_ID, Pokemon>();


    public Pokemon currentPlayerPokemon;
    public Pokemon currentEnemyPokemon;


    public TMP_Text dialogueText;


    private void Awake() {
        //If Singleton (Instance) exists, it deletes it. If not, it initializes it 
        if (Instance != null && Instance != this) {
            Destroy(this);
        } else {
            Instance = this;
        }

        pokemonProperties = GetComponent<PokemonProperties>();
    }
    private void Start() {
        GetInternalPokemons();
        dialogueText.text = "What will " + currentPlayerPokemon.name + " do?";
    }

    private void Update() {
        
    }

    public void pokemonAttack(Pokemon_ID attacker, Move_ID move, Pokemon_ID target) {

        float damage;

        Move playerMove = moveList.moves[move];


    }

    //This is the method that is called when the player selects a move for their pokemon to do.
    //It recieves data of player's, the move it used and data from the enemie's pokemon to calculate damage and apply it
    public void playerAttack(int moveIndex) {


        //We save the move that player's pokemon used in a variable using the moveIndex to make the code easier to read
        Move playerMove = currentPlayerPokemon.moveSet[moveIndex];

        //String where we deposit the dialogue we want to show depending on the phase we are in
        string nextDialogueText = "";

        //First of all, we check if attack did hit base on the Accuaracy stat of the move
        if (Random.Range(0, playerMove.ACC) < playerMove.ACC) {
            //float that will hold the calculated damage
            float damage = 0;

            //We check if the used move is special or not, so we can use the "Attack" and "Defense" stats for the damage formula or "Special Attack" and "Sepcial Defense" stats
            switch (playerMove.category) {
                case MoveCategory_ID.PHYSICAL:
                    damage = ((2f * currentPlayerPokemon.level / 5) + 2) * (playerMove.PWR) * (currentPlayerPokemon.sp_Atkk / currentEnemyPokemon.sp_Deff) / 50 / 2;
                    break;

                case MoveCategory_ID.SPECIAL:
                    damage = ((2f * currentPlayerPokemon.level / 5) + 2) * (playerMove.PWR) * (currentPlayerPokemon.attack / currentEnemyPokemon.defense) / 50 / 2;
                    break;

            }

            //Calculates STAB (Same Type Attack Bonus)
            if (playerMove.type == currentPlayerPokemon.type) {
                damage = damage + damage * 0.5f;
            }

            //Creates a random number to simulate a 1 in 12 probabilty to check if the hit was a critical hit
            int criticalHit = Random.Range(0, 12);
            if (criticalHit == 1) {
                damage = damage * 1.5f;
            }

            //Checks elemental weakness or resistance
            damage = damage * ElementalWeaknessOrResistanceMultiplier(playerMove, currentEnemyPokemon);




            //Applies damage to enemy pokemon
            currentEnemyPokemon.actualHP = currentEnemyPokemon.actualHP - damage;


            if (criticalHit == 1) {
                nextDialogueText = "Critical hit!";
            }

            waitSeconds(1.5f);

            switch (ElementalWeaknessOrResistanceMultiplier(playerMove, currentEnemyPokemon)) {
                case 0.5f:
                    nextDialogueText = "It wasn't very effective";
                    break;
                case 1:
                    nextDialogueText = "It hit!";
                    break;
                case 2:
                    nextDialogueText = "It was super effective!!";
                    break;
                default:

                    break;
            }

            dialogueText.text = nextDialogueText;
        } 
        
        else {
            dialogueText.text = "It missed";
        }



        

    }

    public void enemieAttack() {

    }


    //Adds the pokemon from public list of GameManager to internal dictionary in CombatManager
    private void GetInternalPokemons() {
        for (int i = 0; i < GameManager.Instance.playerPokemons.Length; i++) {
            playerPokemonList.Add(pokemonProperties.Pokedex[GameManager.Instance.playerPokemons[i]].id, pokemonProperties.Pokedex[GameManager.Instance.playerPokemons[i]]);
        }

        for (int i = 0; i < GameManager.Instance.enemyPokemons.Length; i++) {
            enemyPokemonList.Add(pokemonProperties.Pokedex[GameManager.Instance.enemyPokemons[i]].id, pokemonProperties.Pokedex[GameManager.Instance.enemyPokemons[i]]);
        }

        currentPlayerPokemon = playerPokemonList[GameManager.Instance.playerPokemons[0]];
        currentEnemyPokemon = enemyPokemonList[GameManager.Instance.enemyPokemons[0]];
        


    }

    public void ApplyAbility(Pokemon pokemon) {
        switch (pokemon.ability) {
            case Ability_ID.ADAPTABILITY:
                break;
            case Ability_ID.AERILATE:
                break;
            case Ability_ID.BATTERY:
                break;
            case Ability_ID.CLEAR_BODY:
                break;
            default:
                break;
        }
    }


    //This checks both, the current player pokemon type and the enemy pokemon type and returns a damage multiplier depending if the
    //target pokemon is either, resistant, weak or neutral to the attacking move type

    //The damage multipliers work like this:
    //Resistant: 0.5x damage
    //Weak: 2x damage
    //Neutral: 1x damage
    private float ElementalWeaknessOrResistanceMultiplier(Move attacker, Pokemon target) {
        

        switch (attacker.type) {
            case Type_ID.NORMAL:
                switch (target.type) {
                    case Type_ID.GHOST:
                        return 0;
                    default:
                        return 1;
                }

            case Type_ID.FIRE:
                switch (target.type) {
                    case Type_ID.FIRE:
                        return 0.5f;
                    case Type_ID.WATER:
                        return 0.5f;
                    case Type_ID.GRASS:
                        return 2f;
                    
                    default:
                        return 1f;
                }

            case Type_ID.WATER:
                switch (target.type) {
                    case Type_ID.FIRE:
                        return 2f;
                    case Type_ID.WATER:
                        return 0.5f;                        
                    case Type_ID.GRASS:
                        return 0.5f;
                    default:
                        return 1;
                }

            case Type_ID.GRASS:
                switch (target.type) {
                    case Type_ID.FIRE:
                        return 0.5f;
                    case Type_ID.WATER:
                        return 2f;
                    case Type_ID.GRASS:
                        return 0.5f;
                    default:
                        return 1;
                }

            case Type_ID.ELECTRIC:
                switch (target.type) {
                    case Type_ID.WATER:
                        return 2f;
                    case Type_ID.GRASS:
                        return 0.5f;
                    case Type_ID.ELECTRIC:
                        return 0.5f;
                    default:
                        return 1f;
                }

            case Type_ID.GHOST:
                switch (target.type) {
                    case Type_ID.NORMAL:
                        return 0;
                    default:
                        return 1;
                }
            default:

                return 1;
        }
        
    }

    IEnumerator waitSeconds(float seconds) {
        yield return new WaitForSeconds(seconds);
    }

}
