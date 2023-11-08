using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sheep : Animal // INHERITANCE
{
    protected override void Start() // POLYMORPHISM
    {
        producedItem = "Wool";
        base.Start();
    }
}
