using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class StringHandler : MonoBehaviour {

    public Text UIText;
    private StringBuilder sb;

	// Use this for initialization
	void Start () {
        //Create a String builder with a current size of
        //1024 and max capacity of 1024
        sb = new StringBuilder(1024, 1024);
	}
}
