using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterInventory : MonoBehaviour {

    public delegate void OnItemChanged();
    public OnItemChanged onItemChangedCallback;

    public int space = 10;
    public List<ItemObjects> items { private set; get; }

    public bool Add(ItemObjects item)
    {
        if(!item.isEmptyItem)
        {
            if(items.Count >= space)
            {
                return false;
            }
            items.Add(item);
        }
        return true;
    }
    public void Remove(ItemObjects item)
    {
        items.Remove(item);
    }
}
