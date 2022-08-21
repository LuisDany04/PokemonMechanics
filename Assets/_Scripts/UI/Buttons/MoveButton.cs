using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveButton : MonoBehaviour {
    private Button button;
    public int buttonIndex;

    private void Start() {
        button.onClick.AddListener(TriggerAttack);

    }

    private void TriggerAttack() {
        CombatManager.Instance.playerAttack(buttonIndex);
    }

}

