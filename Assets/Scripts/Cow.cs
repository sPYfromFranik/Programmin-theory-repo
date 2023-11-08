using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cow : Animal // INHERITANCE
{
    protected override void Start() // POLYMORPHISM
    {
        movementSpeed = 0.7f;
        producedItem = "Milk";
        base.Start();
    }
}
