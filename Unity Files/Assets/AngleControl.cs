using UnityEngine;
using System.Collections;

public class AngleControl : MonoBehaviour {
	
	public int xRotation = 0;
	public int yRotation = 0;
	public int zRotation = 0;
	public int rotSpeed = 17;

	public Vector3 forwardForce;
	public Vector3 reverseForce;

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
		
		if (Input.GetKey (KeyCode.A))
		{
			Left ();
		}
		
		if (Input.GetKey (KeyCode.D))
		{
			Right ();
		}
		
		if (Input.GetKey (KeyCode.LeftShift))
		{
		}
		
			Vector3 nintyMinus = new Vector3 (-90, 0, 0);
			transform.Translate((transform.forward - nintyMinus) / 200);
	}
		
		void Up ()
		{
			//if ((transform.eulerAngles.x >= 0 && transform.eulerAngles.x <= 45) || transform.eulerAngles.x >= 313) //Works if Greater than 313 aor less than 45
			//{
				float translation = Time.deltaTime * rotSpeed;
				transform.Rotate(Vector3.down, translation);
			//}
		}
		
		void Down ()
		{
			//if ((transform.eulerAngles.x >= 0 && transform.eulerAngles.x <= 47) || transform.eulerAngles.x >= 315) //Works if Greater than 315 or less than 47
			//{
				float translation = Time.deltaTime * rotSpeed;
				transform.Rotate(Vector3.up, translation);
			//}
		}
	
		void Left ()
		{
			//if ((transform.eulerAngles.y >= 0 && transform.eulerAngles.y <= 45) || transform.eulerAngles.y >= 313) //Works if Greater than 315 or less than 47
			//{
				float translation = Time.deltaTime * rotSpeed;
				transform.Rotate(Vector3.right, translation);
			//}
		}
	
		void Right ()
		{
			//if ((transform.eulerAngles.y >= 0 && transform.eulerAngles.y <= 47) || transform.eulerAngles.y >= 315) //Works if Greater than 315 or less than 47
			//{
				float translation = Time.deltaTime * rotSpeed;
				transform.Rotate(Vector3.left, translation);
			//}
		}
}
