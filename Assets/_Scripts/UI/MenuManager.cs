using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MenuManager : MonoBehaviour
{

    //Singleton
    public static MenuManager Instance;

    //GameObjects to actiave/deactivate
    public GameObject actionsMenu;
    public GameObject[] Menus;


    private void Awake() {
        //If Singleton (Instance) exists, it deletes it. If not, it initializes it
        if (Instance != null && Instance != this) {
            Destroy(this);
        } else {
            Instance = this;
        }
    }

    private void Update() {

        if (inputSystem.Instance.Back == 1) {
            SwtichToActionButtons();
        }

    }


    private void SwtichToActionButtons() {
        inputSystem.Instance.Back = 0;
        for (int i = 0; i < Menus.Length; i++) {
            Menus[i].SetActive(false);
        }
        actionsMenu.SetActive(true);
    }
}
