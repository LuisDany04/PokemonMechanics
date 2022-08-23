using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //Singleton
    public static GameManager Instance;

    //Instances of other scripts
    PokemonProperties pokemonProperties;    //Class that contains all the Pokemon Data

    /*

    public Pokemon_ID currentPlayerPokemon;  //Player pokemon in battle
    public Pokemon_ID currentEnemyPokemon;  //Enemy pokemon in battle
    
    */
    
    public Pokemon_ID[] playerPokemons;       //All the Pokemons player has in his "bag" and are available to switch
    public Pokemon_ID[] enemyPokemons;       //All the Pokemons enemy has in his "bag" and are available to switch

    //Holds the Pokemon's sprites (Front and Back)
    public Sprite[] pokemonPlayerSprites;
    public Sprite[] pokemonEnemySprites;


    //////COMBAT RELATED//////
    

    //Texts
    public TextMeshProUGUI Dialogue;  //Main Dialogue Window, the one that says "What will CHARIZARD do?"

    //Player Pokemon Data
    [Header("ENEMY CURRENT POKEMON DATA")]
    public Image playerSprite;
    public TextMeshProUGUI playerPokemonName;
    public Slider playerHP;

    //Enemy Pokemon Data
    [Header("ENEMY CURRENT POKEMON DATA")]
    public Image enemySprite;
    public TextMeshProUGUI enemyPokemonName;
    public Slider enemyHP;


    private void Awake() {

        //If Singleton (Instance) exists, it deletes it. If not, it initializes it 
        if (Instance != null && Instance != this) {
            Destroy(this);
        } else {
            Instance = this;
        }

        pokemonProperties = GetComponent<PokemonProperties>();
    }


    

    string pokemon;

    private void Start() {
        //Debug.Log(pokemonProperties.Pokedex[playerPokemons[2]].id);

    }

    

    private void Update() {
        Dialogue.text = "What will " + CombatManager.Instance.currentPlayerPokemon.name + " do?";
        DisplayPlayerPokemonData();
    }




    //Gets the data of enemy's and player's pokemon and displays it in the UI
    private void DisplayPlayerPokemonData() {
        //PlayerData
        playerSprite.sprite = pokemonPlayerSprites[(int)CombatManager.Instance.currentPlayerPokemon.id];
        playerPokemonName.text = CombatManager.Instance.currentPlayerPokemon.name;
        playerHP.maxValue = CombatManager.Instance.currentPlayerPokemon.maxHP;
        playerHP.value = CombatManager.Instance.currentPlayerPokemon.actualHP;

        //Enemy Data
        enemySprite.sprite = pokemonEnemySprites[(int)CombatManager.Instance.currentEnemyPokemon.id];
        enemyPokemonName.text = CombatManager.Instance.currentEnemyPokemon.name;
        enemyHP.maxValue = CombatManager.Instance.currentEnemyPokemon.maxHP; 
        enemyHP.value = CombatManager.Instance.currentEnemyPokemon.actualHP;
    }
}
