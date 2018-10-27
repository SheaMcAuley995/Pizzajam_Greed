using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterInventory : MonoBehaviour {

    public delegate void OnItemChanged();
    public OnItemChanged onItemChangedCallback;

    public int space = 10;
    public List<ItemObjects> items { private set; get; }

    private void Start()
    {
        items = new List<ItemObjects>();
    }

    public void AddObject(ItemObjects item)
    {
        items.Add(item);
    }
    public void Remove(ItemObjects item)
    {
        items.Remove(item);
    }

}

