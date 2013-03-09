using UnityEngine;
using System.Collections;

public class cscript_warp_gate : MonoBehaviour {
	
	public float bobAmount = 1;
	public float lastPosition = 0;
	public float speed = 0.01f;
	
	public bool bobDirection = false;
	
	// Use this for initialization
	void Start () {
		lastPosition = rigidbody.position.y;
	}
	
	// Update is called once per frame
	void Update () {
		if (bobDirection == true)
		{
			if (rigidbody.position.y - lastPosition >= bobAmount)
			{
				bobDirection = false;
				lastPosition = rigidbody.position.y;
			}
			else
			{
				rigidbody.position = new Vector3(rigidbody.position.x, rigidbody.position.y + speed, rigidbody.position.z);
				Debug.Log("Add Up");
			}
		}
		else
		{
			if (lastPosition + rigidbody.position.y <= bobAmount)
			{
				bobDirection = true;
				lastPosition = rigidbody.position.y;
			}
			else
			{
				rigidbody.position = new Vector3(rigidbody.position.x, rigidbody.position.y - speed, rigidbody.position.z);
				Debug.Log("Add Down");
			}
			
		}
	}
}
