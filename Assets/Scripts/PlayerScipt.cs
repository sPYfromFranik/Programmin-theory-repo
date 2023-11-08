using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerScipt : MonoBehaviour
{
    private string carriedItem = string.Empty;
    [SerializeField] TextMeshProUGUI carriedItemText;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Animal") && carriedItem == string.Empty)
        {
            carriedItem = collision.gameObject.GetComponent<Animal>().producedItem;
            carriedItemText.SetText("You are carrying: " + carriedItem);
        }
        if (collision.gameObject.CompareTag("Finish") && carriedItem != string.Empty)
        {
            collision.gameObject.GetComponent<StorageScript>().UpdateText(carriedItem);
            carriedItem = string.Empty;
            carriedItemText.SetText("You are carrying: nothing");
        }
    }
}
