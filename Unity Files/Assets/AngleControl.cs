using UnityEngine;
using System.Collections;

public class AngleControl : MonoBehaviour {
	
	public int xRotation = 0;
	public int yRotation = 0;
	public int zRotation = 0;
	public int rotSpeed = 17;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKey (KeyCode.W))
		{
			Up ();
		}
		
		if (Input.GetKey (KeyCode.S))
		{
			Down ();
		}
	
	}
		
		void Up ()
		{
			float translation = Time.deltaTime * rotSpeed;
			//xRotation = xRotation + 1;
			//Vector3 xRot = new Vector3 (xRotation, yRotation, zRotation);
			transform.Rotate(Vector3.right, translation);
		}
		
		void Down ()
		{
			//xRotation = 0;
			float translation = Time.deltaTime * rotSpeed;
			//xRotation = xRotation - 1;
			//Vector3 xRot = new Vector3 (xRotation, yRotation, zRotation);
			transform.Rotate(Vector3.left, translation);
		}
}
