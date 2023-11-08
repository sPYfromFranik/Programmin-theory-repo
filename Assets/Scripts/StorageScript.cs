using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StorageScript : MonoBehaviour
{
    private int eggs=0;
    private int milk=0;
    private int wool=0;

    public void UpdateText(string receivedItem)
    {
        switch (receivedItem)
        {
            case "Egg":
                eggs++;
                break;
            case "Milk":
                milk++; 
                break;
            case "Wool":
                wool++;
                break;
            default:
                Debug.LogError("Uneidentified type of carried object");
                break;
        }
        gameObject.GetComponentInChildren<TextMeshPro>().SetText("Eggs: " + eggs + "\nMilk: " + milk + "\nWool: " + wool);
    }
}
