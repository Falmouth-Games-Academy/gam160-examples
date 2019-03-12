using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This will add an entry to the Asset/Create menu
[CreateAssetMenu(fileName ="Item",menuName ="Items/Item",order =1)]
public class ItemScriptableObject : ScriptableObject
{
    public string Name;
    public float Quality;
    public float Strength;
    public Sprite Image;
}
