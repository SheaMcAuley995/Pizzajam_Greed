using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterInventory : MonoBehaviour {

    [SerializeField] playerNumber my_Player;

    public delegate void OnItemChanged();
    public OnItemChanged onItemChangedCallback;

    public int space = 10;
    public List<ItemObjects> items { private set; get; }
    public int scoreModifier = 0;

    
    

    private void Start()
    {
        items = new List<ItemObjects>();
    }

    public void AddObject(ItemObjects item)
    {
        if(items.Count <= space)
        {
            bool isAddingMultiplier = true;
            if(items.Count > 0)
            {
                foreach (ItemObjects itemobj in items)
                {
                    if (itemobj != null)
                    {
                        if (itemobj.name == item.name)
                        {
                            isAddingMultiplier = false;
                        }
                    }
                }
            }
            if (isAddingMultiplier)
                scoreModifier++;

            items.Add(item);

        }
    }

    public void countScore()
    {
        int totalScoreBonus = 0;
        foreach (ItemObjects itemobj in items)
        {
            totalScoreBonus += itemobj.scoreBonus;
            Remove(itemobj);
        }
        ScoreManager.instance.addScore(my_Player,totalScoreBonus * scoreModifier);
    }


    public void Remove(ItemObjects item)
    {
        items.Remove(item);
    }

    public void clearInventory()
    {
        foreach (ItemObjects itemobj in items)
        {
            Remove(itemobj);
        }
    }
}

