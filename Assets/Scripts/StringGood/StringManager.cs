using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Character;
using StringHandling;

public class StringManager : MonoBehaviour {

    //Instance of String Handler
    private StringHandler stringHandler;
    //Instance of Character Stats
    private CharacterStats characterStats;

    //UI Text
    public Text UIText;

	// Use this for initialization
	void Start () {
        //Initialise Character Stats
        characterStats = new CharacterStats();
        characterStats.Name = "Brian";
        characterStats.Health = 100;
        characterStats.Strength = 10;
        characterStats.Mana = 100;
        
        //Initialise our string handler class
        stringHandler = new StringHandler();
	}

    private void Update()
    {
        //Add some text and other things to the string builder
        stringHandler.AddText("Name: ");
        stringHandler.AddText(characterStats.Name);
        stringHandler.AddText("\nHealth: ");
        stringHandler.AddText(characterStats.Health);
        stringHandler.AddText("\nStrength: ");
        stringHandler.AddText(characterStats.Strength);
        stringHandler.AddText("\nMana: ");
        stringHandler.AddText(characterStats.Mana);

        //Update the text based on the contents of the string builder
        UIText.text = stringHandler.GetString();
        //Clear the string builder
        stringHandler.Clear();
    }
}
