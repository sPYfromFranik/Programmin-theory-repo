using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chicken : Animal // INHERITANCE
{
    protected override void Start() // POLYMORPHISM
    {
        movementSpeed = 2.5f;
        producedItem = "Egg";
        base.Start();
    }

    protected override void SetDestination() // POLYMORPHISM
    {
        targetPosition = new Vector3(Random.Range(-movementZone, movementZone), Random.Range(0, 2), Random.Range(-movementZone, movementZone));
    }
}
