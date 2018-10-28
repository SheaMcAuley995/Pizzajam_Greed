using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class ItemPickup : MonoBehaviour
{
    float timer;
    public ItemObjects item;

    private void Start()
    {
        timer = 20;
        item.isEmptyItem = false;
        name = item.name;
       // GetComponent<SpriteRenderer>().sprite = item.sprite;
    }

    private void Update()
    {
        timer -= Time.deltaTime;
        if(timer < 0)
        {
            Destroy(gameObject);
        }
    }

    void pickUp(CharacterInventory inventory)
    {
        inventory.AddObject(item);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            pickUp(collision.gameObject.GetComponent<CharacterInventory>());
            Destroy(gameObject);
        }
        
    }
}



