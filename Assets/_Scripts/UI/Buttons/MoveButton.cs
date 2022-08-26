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
        text.text = CombatManager.Instance.currentPlayerPokemon.moveSet[buttonIndex].name;
        button.onClick.AddListener(TriggerAttack);
        
    }

    private void TriggerAttack() {
        if (CombatManager.Instance.canInteract) {
            CombatManager.Instance.playerAttack(buttonIndex);
        }

        
    }

}

