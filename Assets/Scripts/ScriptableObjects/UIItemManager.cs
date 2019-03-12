using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIItemManager : MonoBehaviour {
    //Our Item Panel Prefab
    [SerializeField]
    GameObject ItemPanelPrefab;

    //A list of items to be added
    [SerializeField]
    List<ItemScriptableObject> Items = new List<ItemScriptableObject>();

    //Our Root UI, this is the parent of every item panel added
    [SerializeField]
    Transform UIRoot;

    //This is just a helper list, makes it easier to remove 
    //UIItem panels from the root
    List<GameObject> UIItems = new List<GameObject>();

    // Use this for initialization
    void Start()
    {
        RemoveAllUIItems();
        AddUIItems();
    }

    //Function which removes all Item panels from the root
    void RemoveAllUIItems()
    {
        foreach (GameObject itemUI in UIItems)
        {
            itemUI.transform.SetParent(null);
            Destroy(itemUI);
        }

        UIItems.Clear();
    }

    //Add UI Item Panels
    void AddUIItems()
    {
        foreach (ItemScriptableObject item in Items)
        {
            //Instantiate the Panel prefab
            GameObject itemPanel = Instantiate<GameObject>(ItemPanelPrefab);
            //Grab the UIItem scrript from the spawned panel
            ItemUI itemUI = itemPanel.GetComponent<ItemUI>();
            //Call the Populate function and pass in the current item
            itemUI.PopulateWithScriptableItem(item);

            //Parent the new uipanel with the root
            itemPanel.transform.SetParent(UIRoot, false);

            //Add the new panel to our helper list
            UIItems.Add(itemPanel);
        }
    }
}
