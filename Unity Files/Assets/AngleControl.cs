using UnityEngine;
using System.Collections;

public class AngleControl : MonoBehaviour {
	
	public int zRotation = 20;
	public int rotSpeed = 30;
	public int forSpeed = 250;

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
			yawLeft ();
		}
		
		if (Input.GetKey (KeyCode.D))
		{
			yawRight ();
		}
		
		if (Input.GetKey (KeyCode.Q))
		{
			Left ();
		}
		
		if (Input.GetKey (KeyCode.E))
		{
			Right ();
		}
		
		if (Input.GetKey (KeyCode.LeftShift))
		{
			if (forSpeed >= 150)
			{
				forSpeed = forSpeed - 1;
			}
		}
		
		if (Input.GetKey (KeyCode.LeftControl))
		{
			if (forSpeed <= 500)
			{
				forSpeed = forSpeed + 1;
			}
		}
		
			//Vector3 nintyMinus = new Vector3 (90, 0, 0);
			//transform.Translate((transform.forward - nintyMinus) / forSpeed);
	}
		
		void Up ()
		{
			//if ((transform.eulerAngles.x >= 0 && transform.eulerAngles.x <= 45) || transform.eulerAngles.x >= 313) //Works if Greater than 313 aor less than 45
			//{
				//float translation = Time.deltaTime * rotSpeed;
				//transform.Rotate(Vector3.down, translation);
				transform.Rotate( 0, 0, ((Time.deltaTime * zRotation)));
			//}
		}
		
		void Down ()
		{
			//if ((transform.eulerAngles.x >= 0 && transform.eulerAngles.x <= 47) || transform.eulerAngles.x >= 315) //Works if Greater than 315 or less than 47
			//{
				//float translation = Time.deltaTime * rotSpeed;
				//transform.Rotate(Vector3.up, translation);
				transform.Rotate( 0, 0, (-(Time.deltaTime * zRotation)));
			//}
		}
	
		void yawLeft ()
		{
			//if ((transform.eulerAngles.y >= 0 && transform.eulerAngles.y <= 45) || transform.eulerAngles.y >= 313) //Works if Greater than 315 or less than 47
			//{
				//float translation = Time.deltaTime * rotSpeed;
				//transform.Rotate(Vector3.right, translation);
				transform.Rotate( (-(Time.deltaTime * zRotation)), 0, 0);
			//}
		}
	
		void yawRight ()
		{
			//if ((transform.eulerAngles.y >= 0 && transform.eulerAngles.y <= 47) || transform.eulerAngles.y >= 315) //Works if Greater than 315 or less than 47
			//{
				//float translation = Time.deltaTime * rotSpeed;
				//transform.Rotate(Vector3.left, translation);
				transform.Rotate( ((Time.deltaTime * zRotation)), 0, 0);
			//}
		}
	
		void Left ()
		{	
				transform.Rotate(0, (-(Time.deltaTime * zRotation)), 0);
		}
		
		void Right ()
		{
				transform.Rotate(0, (Time.deltaTime * zRotation), 0);
		}
}
