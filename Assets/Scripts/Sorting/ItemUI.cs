using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Our structure which represents an item (could be a class)
//Notice we implement the IComparable interface
[Serializable]
public struct Item:IComparable<Item>
{
    //Public fields for convience
    public string Name;
    public float Quality;
    public float Strength;
    public Sprite Image;

    //We have to implement this function, we are sorting by name
    public int CompareTo(Item other)
    {
        return Name.CompareTo(other.Name);
    }
}

//Our ItemUI Class, this is the glue between the UI and item instances
public class ItemUI : MonoBehaviour
{
    [SerializeField]
    Text NameTxt;
    [SerializeField]
    Text QualityTxt;
    [SerializeField]
    Text StrenghtTxt;
    [SerializeField]
    Image Image;

    //Called to populate UI with details from Item
    public void PopulateWithItem(Item item)
    {
        NameTxt.text = item.Name;
        QualityTxt.text = item.Quality.ToString();
        StrenghtTxt.text = item.Strength.ToString();
        Image.sprite = item.Image;
    }

    public void PopulateWithScriptableItem(ItemScriptableObject item)
    {
        NameTxt.text = item.Name;
        QualityTxt.text = item.Quality.ToString();
        StrenghtTxt.text = item.Strength.ToString();
        Image.sprite = item.Image;
    }
}
