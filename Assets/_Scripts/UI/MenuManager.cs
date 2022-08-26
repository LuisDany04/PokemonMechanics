using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{

    //*When we refer to "Action Menu" we mean the menu that contains "Fight", "Items", "Switch" and "Run" buttons

    //Singleton
    public static MenuManager Instance;

    //GameObjects to actiave/deactivate
    public GameObject actionsMenu;
    public GameObject[] Menus;

    public enum Menus_ID{
        FIGHT,
        ITEMS,
        SWITCH,
        RUN
    }

    //Buttons
    public Button[] moveButtons;

    private void Awake() {
        //If Singleton (Instance) exists, it deletes it. If not, it initializes it
        if (Instance != null && Instance != this) {
            Destroy(this);
        } else {
            Instance = this;
        }
    }

    private void Update() {

        //Either if you press ESC or the game decides that you can't interact, you go back to Actions Menu
        if (inputSystem.Instance.Back == 1 || CombatManager.Instance.canInteract == false) {
            SwtichToActionButtons();
        }



    }

    //Switches back to the Actions Menu
    public void SwtichToActionButtons() {
        inputSystem.Instance.Back = 0;
        for (int i = 0; i < Menus.Length; i++) {
            Menus[i].SetActive(false);
        }
        actionsMenu.SetActive(true);
    }

    public void SwitchToMenu(Menus_ID menu) {
        for (int i = 0; i < Menus.Length; i++) {
            Menus[i].SetActive(false);
        }

        Menus[(int)menu].SetActive(true);

    }
}
