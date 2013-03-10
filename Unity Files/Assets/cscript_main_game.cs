using UnityEngine;
using System.Collections;

public class cscript_main_game : MonoBehaviour {
	
	public GameObject warpGate;
	public GameObject goBaguette;
	public GameObject goSaucer;
	
	public GameObject asOne;
	public GameObject asTwo;
	public GameObject asThree;
	public GameObject asIce;
	
	int gatesToSpawn = 30;
	int asteroidsToSpawn = 200;
	
	public bool drawCharacterSelect = true;
	
	// Use this for initialization
	void Start () {
		//transform.rotation = new Vector3(0, 270, 0);
		GenerateGates ();
		SpawnAsteroids ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void GenerateGates() {
		for (int i = 0; i < gatesToSpawn; i++)
		{
			GameObject instance = Instantiate(warpGate, new Vector3(Random.Range (-200, 200), Random.Range (-200, 200), Random.Range (-200, 200)), Quaternion.Euler(270, 0, Random.Range (0, 360))) as GameObject;
		}
	}
	
	void OnGUI () 
	{
		if (drawCharacterSelect == true)
		{
			if (GUI.Button (new Rect (200, 200, 100, 30), "Good ol' British"))
				SpawnPlane(0);
		
			if (GUI.Button (new Rect (200, 240, 100, 30), "La French"))
				SpawnPlane(1);
		}
		
	}
	
	void SpawnPlane(int planeSelection)
	{
		drawCharacterSelect = false;
		
		switch (planeSelection)
		{
			case 0: 
				GameObject saucer = Instantiate(goSaucer, new Vector3(Random.Range (-500, 500), Random.Range (-500, 500), Random.Range (-500, 500)), Quaternion.Euler(270, 0, Random.Range (0, 360))) as GameObject;
				break;
			case 1:
				GameObject bageutte = Instantiate(goBaguette, new Vector3(Random.Range (-500, 500), Random.Range (-500, 500), Random.Range (-500, 500)), Quaternion.Euler(270, 0, Random.Range (0, 360))) as GameObject;
				break;
		}
	}
	
	void SpawnAsteroids()
	{
		for (int i = 0; i < asteroidsToSpawn; i++)
		{
			GameObject asSpawn1 = Instantiate(asOne, new Vector3(Random.Range (-200, 200), Random.Range (-200, 200), Random.Range (-200, 200)), Quaternion.Euler(270, 0, Random.Range (0, 360))) as GameObject;
			GameObject asSpawn2 = Instantiate(asTwo, new Vector3(Random.Range (-200, 200), Random.Range (-200, 200), Random.Range (-200, 200)), Quaternion.Euler(270, 0, Random.Range (0, 360))) as GameObject;
			GameObject asSpawn3 = Instantiate(asThree, new Vector3(Random.Range (-200, 200), Random.Range (-200, 200), Random.Range (-200, 200)), Quaternion.Euler(270, 0, Random.Range (0, 360))) as GameObject;
			GameObject asSpawn4 = Instantiate(asIce, new Vector3(Random.Range (-200, 200), Random.Range (-200, 200), Random.Range (-200, 200)), Quaternion.Euler(270, 0, Random.Range (0, 360))) as GameObject;
		}
	}
}
