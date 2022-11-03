using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SwitchButton : MonoBehaviour
{
    public int buttonIndex;

    public TMP_Text buttonText;

    public GameObject parentObject;

    private void Start() {

        if (CombatManager.Instance.playerPokemonList.Count > buttonIndex) {
            //Gets the name of the pokemon based in the given index and displays it's name
            buttonText.text = CombatManager.Instance.playerPokemonList[buttonIndex].name;
        } 
        else {
            //If there's no Pokemon to fill this button, it gets destroyed
            Destroy(gameObject);
        }
        
    }

    public void OnClic() {
        //Changes the current pokemon in combat for the chosed one
        CombatManager.Instance.currentPlayerPokemon = CombatManager.Instance.playerPokemonList[buttonIndex];

        //Switches back to Action Menu after switching Pokemon
        MenuManager.Instance.SwtichToActionButtons();

        //Ends turn and lets enemy pokemon attack
        CombatManager.Instance.EnemieAttack();
    }
}
