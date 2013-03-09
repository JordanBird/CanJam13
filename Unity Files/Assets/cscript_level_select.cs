using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class cscript_level_select : MonoBehaviour {
	
	public List<string> levelNames = new List<string>();
	
	// Use this for initialization
	void Start () {
		levelNames.Add ("TestLevel");
		levelNames.Add ("TestLevel");
		levelNames.Add ("TestLevel");
		levelNames.Add ("TestLevel");
	}
	
	void OnGUI () {
		int y = 200;
		
		for (int i = 0; i < levelNames.Count; i++)
		{
			if (GUI.Button (new Rect (200, y, 100, 30), "Load Level"))
				Application.LoadLevel (levelNames[i]);
				
			y += 40;
		}
		
		if (GUI.Button (new Rect (200, y, 100, 30), "Back")) {
			Application.LoadLevel ("JordansScene");
		}
		
		y += 40;
		
		if (GUI.Button (new Rect (200, y, 100, 30), "Quit")) {
			Application.Quit ();
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
