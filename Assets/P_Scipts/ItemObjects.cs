using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Ingredient",menuName = "Ingredient", order = 0)]
public class ItemObjects : ScriptableObject {

    public new string name = "";
    public Sprite sprite = null;
    public int scoreBonus = 0;
    public bool isEmptyItem = true;
}
