using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{
    Equipable,
    Consumable,
    Resource
}

public enum ConsumableType
{
    Health,
    Mana
}

[Serializable]
public class ItemDataConbumable
{
    public ConsumableType type;
    public float value;
}

[CreateAssetMenu(fileName = "Item",menuName = "New Item")]


public class ItemData : ScriptableObject
{
    [Header("Info")]
    public string displayName;
    public string description;
    public ItemType type;
    public Sprite icon;
    public GameObject dropPrefab;

    [Header("Stakcing")]
    public bool canStack;
    public int maxStackAmount;

    [Header("Consumable")]
    public ItemDataConbumable[] consumables;
}
