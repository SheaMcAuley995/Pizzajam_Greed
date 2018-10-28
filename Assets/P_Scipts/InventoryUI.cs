using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InventoryUI : MonoBehaviour {

    [SerializeField] TextMeshProUGUI numSlot_One;
    [SerializeField] TextMeshProUGUI numSlot_Two;
    [SerializeField] TextMeshProUGUI numSlot_Three;
    [SerializeField] TextMeshProUGUI MultiplierNum;

    [SerializeField] CharacterInventory inventory;

	void Update () {

        unoptimizedGarbageUpdateGUI();

    }
    
    private void unoptimizedGarbageUpdateGUI()
    {
        int num1 = 0;
        int num2 = 0;
        int num3 = 0;

        
        MultiplierNum.text = inventory.scoreModifier.ToString();
        foreach(ItemObjects obj in inventory.items)
        {
            if(obj.name == "CandyCorn")
            {
                num1++;
            }
            else if(obj.name == "Coin")
            {
                num2++;
            }
            else if(obj.name == "Diamond")
            {
                num3++;
            }
        }
        numSlot_One.text = num1.ToString();
        numSlot_Two.text = num2.ToString();
        numSlot_Three.text = num3.ToString();
    }

    
   
}
