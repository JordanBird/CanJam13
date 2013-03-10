using UnityEngine;
using System.Collections;

public class cupRotator : MonoBehaviour {
	

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		float translation = Time.deltaTime * 500;
		transform.Rotate(Vector3.up, translation);
	}
}
