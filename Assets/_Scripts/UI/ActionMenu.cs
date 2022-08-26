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

        
    }

}
