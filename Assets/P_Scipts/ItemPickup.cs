using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class ItemPickup : MonoBehaviour {

    [SerializeField] ItemObjects item;
    private CharacterInventory inventory;

    private void Start()
    {
        item.isEmptyItem = false;
        name = item.name;
        GetComponent<SpriteRenderer>().sprite = item.sprite;
    }


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            inventory = collision.gameObject.GetComponent<CharacterInventory>();

            bool wasPickedup = inventory.Add(item);

            if (wasPickedup)
                Destroy(collision.gameObject);
        }
    }
}
