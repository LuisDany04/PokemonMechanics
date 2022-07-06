using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    //Array to hold our buttons
    public GameObject[] MovesetText;

    //Array to represent the button that is currently selected
    int[,] buttonPosition = new int[2, 2];



    //Coordinates to move through array
    int X;
    int Y;

    private void Start() {
        X = 0;
        Y = 0;
    }

    private void Update() {
        
    }
}
