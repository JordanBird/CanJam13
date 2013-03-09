using UnityEngine;
using System.Collections;

public class cscript_warp_gate : MonoBehaviour {
	
	public Light myLight; 
	
	// Use this for initialization
	void Start () {
		GameObject light = GameObject.FindWithTag("Light");
       	myLight = light.GetComponent<Light>();
       	myLight.enabled = false;
	}
	
	// Update is called once per frame
	
	void OnTriggerEnter(Collider col) {
		myLight.enabled = !myLight.enabled;
	}
}
