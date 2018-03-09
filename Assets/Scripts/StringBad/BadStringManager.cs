using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Character;

public class BadStringManager : MonoBehaviour {

    //UI Text to hold the text
    public Text UIText;

    //The characters stats, this is what we are displaying
    //to the user
    private CharacterStats characterStats;


    // Use this for initialization
    void Start () {
        //Initialise the chacter stats to default values
        characterStats = new CharacterStats();
        characterStats.Name = "Jo";
        characterStats.Health = 80;
        characterStats.Mana = 0;
        characterStats.Strength = 10;
	}
	
	// Update is called once per frame
	void Update () {
        //Update the text, we wouldn't do this every frame!
        UIText.text = "Name: " + characterStats.Name + "\nHealth: " + 
            characterStats.Health.ToString() + "\nStrength:  " + 
            characterStats.Strength.ToString() + "\nMana: " + 
            characterStats.Mana;
	}
}
