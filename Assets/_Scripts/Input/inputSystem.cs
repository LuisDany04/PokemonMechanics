using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Interactions;
using UnityEngine;

public class inputSystem : MonoBehaviour
{
    //Singleton
    public static inputSystem Instance;

    //Accesing the InputAction asset
    InputActions InputActions;


    //Inputs as variables
    public float X;
    public float Y;
    public float Action;
    public float Back;


    private void Awake() {

        //If Singleton (Instance) exists, it deletes it. If not, it initializes it
        if (Instance != null && Instance != this) {
            Destroy(this);
        } else {
            Instance = this;
        }

        InputActions = new InputActions();
    }

    private void Start() {
        GetInputs();
    }

    



    //Subscribes to the performed event to get the inputs.   ONLY GETS THE INPUT IF IT IS A "TAP" INTERACTION (Can be changed in the InputActions asset in the /_Scripts/Input folder)
    private void GetInputs() {

        InputActions.Basic.X.performed += ctx => {
            if (ctx.interaction is TapInteraction) {
                Y = InputActions.Basic.X.ReadValue<float>();


            }
        };

        InputActions.Basic.Y.performed += ctx => {
            if (ctx.interaction is TapInteraction) {
                Y = InputActions.Basic.Y.ReadValue<float>();

            }
        };

        InputActions.Basic.Action.performed += ctx => {
            if (ctx.interaction is TapInteraction) {
                Y = InputActions.Basic.Action.ReadValue<float>();

            }
        };

        InputActions.Basic.Back.performed += ctx => {
            if (ctx.interaction is TapInteraction) {
                Back = 1;
            }
        };
    }



    //OnEnable and OnDisable are required for the input system to work
    private void OnEnable() {
        InputActions.Enable();
    }

    private void OnDisable() {
        InputActions.Disable();
    }

}
