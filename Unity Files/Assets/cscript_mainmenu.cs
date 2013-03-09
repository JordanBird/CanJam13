using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class cscript_mainmenu : MonoBehaviour {
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnGUI () {
		if (GUI.Button (new Rect (200, 200, 100, 30), "Load Level"))
				Application.LoadLevel ("TestLevel");
		
		if (GUI.Button (new Rect (200, 240, 100, 30), "Select Level"))
				Application.LoadLevel ("LevelSelect");
		
		if (GUI.Button (new Rect (200, 280, 100, 30), "Quit")) {
			Application.Quit ();
		}
	}
}