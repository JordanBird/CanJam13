using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		float translation = Time.deltaTime * 15;
		transform.Rotate(Vector3.up, translation);
		transform.Rotate(Vector3.right, translation);
		transform.Rotate(Vector3.forward, translation);
		transform.Rotate(Vector3.left, translation);
	}
}
