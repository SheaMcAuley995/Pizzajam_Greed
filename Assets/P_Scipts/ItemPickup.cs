using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour {

    public ItemObjects item;
    private CharacterInventory inventory;

    private void Start()
    {
        inventory = GetComponent<CharacterInventory>();
    }

    private void Pickup()
    {
        inventory
    }
}
