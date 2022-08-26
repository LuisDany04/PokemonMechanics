using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MoveButton : MonoBehaviour {
    
    private Button button;
    public int buttonIndex;
    public TMP_Text text;
    private void Awake() {
        button = GetComponent<Button>();
        
    }



    private void Start() {
        

        //Link the TriggerAttack method to the onClic event
        button.onClick.AddListener(TriggerAttack);
        
    }

    private void OnEnable() {
        //Gets the name of the Move based in the buttonIndex given
        text.text = CombatManager.Instance.currentPlayerPokemon.moveSet[buttonIndex].name;
    }

    //Triggers the attack action using the PlayerAttack method in the CombatManager
    private void TriggerAttack() {
        if (CombatManager.Instance.canInteract) {
            CombatManager.Instance.PlayerAttack(buttonIndex);
        }

        
    }

}

