using UnityEngine;
using System.Collections;

public class cscript_level_select : MonoBehaviour {
	
	public List<string> levelNames = new List<string>();
	
	// Use this for initialization
	void Start () {
		levelNames.Add ("TestLevel");
		levelNames.Add ("TestLevel");
		levelNames.Add ("TestLevel");
		levelNames.Add ("TestLevel");
	}
	
	// Update is called once per frame
	void Update () {
		int y = 200;
		
		for (int i = 0; i < levelNames.Count; i++)
		{
			if (GUI.Button (new Rect (200, y, 100, 30), "Load Level"))
				Application.LoadLevel (levelNames[i]);
				
			y += 40;
		}
		
		if (GUI.Button (new Rect (200, y, 100, 30), "Quit")) {
			Application.Quit ();
		}
	}
}
