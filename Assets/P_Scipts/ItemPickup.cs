using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class ItemPickup : MonoBehaviour
{

    public ItemObjects item;

    private void Start()
    {
        item.isEmptyItem = false;
        name = item.name;
        GetComponent<SpriteRenderer>().sprite = item.sprite;
    }

    void pickUp(CharacterInventory inventory)
    {
        inventory.AddObject(item);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            Debug.Log(collision.gameObject.name);
            pickUp(collision.gameObject.GetComponent<CharacterInventory>());
            Destroy(gameObject);
        }
    }

}



