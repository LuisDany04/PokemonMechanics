using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ActionMenu : MonoBehaviour {
    //Array to hold our buttons
    public GameObject[] buttons;

    //Array to represent the button that is currently selected
    int[,] buttonValue = new int[2, 2];



    //Coordinates to move through array
    int X;
    int Y;

    private void Start() {
        //Sets the initial position in the first position of the array
        buttonValue[0, 0] = 1;
    }

    private void Update() {

        //Checks
        for (int i = 0; i < 2; i++) {
            for (int n = 0; n < 2; n++) {
                if (buttonValue[i,n] == 1) {
                    DisplaySelectedButton(buttons[i], true);
                    Debug.Log("Selected button detected");
                } else {
                    DisplaySelectedButton(buttons[i], false);
                }
            }
            
        }
    }

    private void menuMovement() {

    }



    private void DisplaySelectedButton(GameObject button, bool selected) {
        switch (selected) {
            case true:
                button.GetComponent<TextMeshProUGUI>().color = new Color(140, 20, 252, 1);

                break;
            case false:
                //button.GetComponent<TextMeshProUGUI>().color = Color.black;
                break;
        }

        
    }
}
