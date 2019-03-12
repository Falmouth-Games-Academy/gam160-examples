using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Custom sort of Item class using a class which inherits from IComparer
public class QualitySort : IComparer<Item>
{
    //You must implement the Compare function
    public int Compare(Item x, Item y)
    {
        //Use the quality variable for comparison
        return x.Quality.CompareTo(y.Quality);
    }
}

public class UIManager : MonoBehaviour {

    //Our Item Panel Prefab
    [SerializeField]
    GameObject ItemPanelPrefab;

    //A list of items to be added
    [SerializeField]
    List<Item> Items=new List<Item>();

    //Our Root UI, this is the parent of every item panel added
    [SerializeField]
    Transform UIRoot;

    //This is just a helper list, makes it easier to remove 
    //UIItem panels from the root
    List<GameObject> UIItems = new List<GameObject>();

    // Use this for initialization
    void Start () {
        RemoveAllUIItems();
        AddUIItems();
    }

    //Function which removes all Item panels from the root
    void RemoveAllUIItems()
    {
        foreach(GameObject itemUI in UIItems)
        {
            itemUI.transform.SetParent(null);
            Destroy(itemUI);
        }

        UIItems.Clear();
    }

    //Add UI Item Panels
    void AddUIItems()
    {
        foreach (Item item in Items)
        {
            //Instantiate the Panel prefab
            GameObject itemPanel = Instantiate<GameObject>(ItemPanelPrefab);
            //Grab the UIItem scrript from the spawned panel
            ItemUI itemUI = itemPanel.GetComponent<ItemUI>();
            //Call the Populate function and pass in the current item
            itemUI.PopulateWithItem(item);

            //Parent the new uipanel with the root
            itemPanel.transform.SetParent(UIRoot, false);

            //Add the new panel to our helper list
            UIItems.Add(itemPanel);
        }
    }

    //Called when the sort by name button is pressed
    public void SortByNamePressed()
    {
        RemoveAllUIItems();
        //Sort using standard sort (IComparable in struct)
        Items.Sort();
        AddUIItems();
    }

    //Called when the sort by strength is pressed
    public void SortByStrengthPressed()
    {
        RemoveAllUIItems();
        //Sort using a delegate
        Items.Sort(delegate (Item item1, Item item2)
        {
            return (item1.Strength.CompareTo(item2.Strength));
        });

        AddUIItems();
    }

    //Called when the sort by quality is pressed
    public void SortByQualityPressed()
    {
        RemoveAllUIItems();

        //Sort using a class which inherits from IComparer
        Items.Sort(new QualitySort());

        AddUIItems();
    }
}
