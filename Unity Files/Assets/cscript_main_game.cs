using UnityEngine;
using System.Collections;

public class cscript_main_game : MonoBehaviour {
	
	public GameObject warpGate;
	int gatesToSpawn = 30;

	// Use this for initialization
	void Start () {
		//transform.rotation = new Vector3(0, 270, 0);
		GenerateGates ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void GenerateGates() {
		for (int i = 0; i < gatesToSpawn; i++)
		{
			GameObject instance = Instantiate(warpGate, new Vector3(Random.Range (-500, 500), Random.Range (-500, 500), Random.Range (-500, 500)), Quaternion.Euler(270, 0, Random.Range (0, 360))) as GameObject;
		}
	}
}
