using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    //Properties
    string name;
    Type_ID type;
    int PWR;
    int ACC;
    int PP;
    bool EFC;

    public Move(string name, Type_ID type, int PWR, int ACC, int PP, bool EFC) {
        this.name = name;
        this.type = type;
        this.PWR = PWR;
        this.ACC = ACC; 
        this.PP = PP;
        this.EFC = EFC;
    }
}
