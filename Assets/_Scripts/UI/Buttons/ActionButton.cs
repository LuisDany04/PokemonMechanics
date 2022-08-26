using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionButton : MonoBehaviour
{
    public GameObject self; //Reference to the Action Menu Buttons

    public enum Button_ID {
        _1,
        _2,
        _3,
        _4
    }

    public Button_ID index;

    public void OnClic() {
        if (CombatManager.Instance.canInteract) {
            switch (index) {
                case Button_ID._1:
                    SwitchMenus((int)Button_ID._1);
                    break;
                case Button_ID._2:
                    SwitchMenus((int)Button_ID._2);
                    break;
                case Button_ID._3:
                    SwitchMenus((int)Button_ID._3);
                    break;
                case Button_ID._4:
                    CombatManager.Instance.dialogueText.text = "You can't escape";
                    break;
                default:
                    break;
            }
        }
        
    }

    
    private void SwitchMenus(int menuIndex) {

        for (int i = 0; i < MenuManager.Instance.Menus.Length; i++) {
            MenuManager.Instance.Menus[i].SetActive(false);
        }
        MenuManager.Instance.Menus[menuIndex].SetActive(true);
        self.SetActive(false);
        
    }
}
