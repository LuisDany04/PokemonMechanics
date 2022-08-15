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

    [SerializeField]
    private Pokemon_ID currentPlayerPokemon;  //Player pokemon in battle
    [SerializeField]
    private Pokemon_ID currentEnemyPokemon;  //Enemy pokemon in battle
    [SerializeField]
    private Pokemon_ID[] ownedPokemon;       //All the Pokemons player has in his "bag" and are available to switch

    //Holds the Pokemon's sprites (Front and Back)
    public Sprite[] pokemonPlayerSprites;
    public Sprite[] pokemonEnemySprites;


    //Texts
    public TextMeshProUGUI Dialogue;  //Main Dialogue Window, the one that says "What will CHARIZARD do?"

    //Player Pokemon Data
    [Header("ENEMY CURRENT POKEMON DATA")]
    public Image playerSprite;
    public TextMeshProUGUI playerPokemonName;

    //Enemy Pokemon Data
    [Header("ENEMY CURRENT POKEMON DATA")]
    public Image enemySprite;
    public TextMeshProUGUI enemyPokemonName;


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



    }

    private void Update() {
        DisplayPlayerPokemonData();
    }




    //Gets the data of enemy's and player's pokemon and displays it in the UI
    private void DisplayPlayerPokemonData() {
        //PlayerData
        playerSprite.sprite = pokemonPlayerSprites[(int)currentPlayerPokemon];
        playerPokemonName.text = pokemonProperties.Pokedex[currentPlayerPokemon].name;
        Dialogue.text = "What will " + pokemonProperties.Pokedex[currentPlayerPokemon].name + " do?";

        //Enemy Data
        enemySprite.sprite = pokemonEnemySprites[(int)currentEnemyPokemon];
        enemyPokemonName.text = pokemonProperties.Pokedex[currentEnemyPokemon].name;
    }
}
