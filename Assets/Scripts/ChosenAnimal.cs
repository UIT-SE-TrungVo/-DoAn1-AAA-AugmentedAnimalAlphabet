using System.Collections;
using System.Collections.Generic;
using UnityEngine;

static public class ChosenAnimal
{
    static private int _index = 0;
    static public int Index { 
        get => _index;
        set { _index = value; } 
    }
}
