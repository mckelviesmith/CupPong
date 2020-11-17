using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballMovement : MonoBehaviour 
{
	public float rotateSpeed = 50.0f;
	private float force=1650f;
	public GameObject line;
	public GameObject cone;
	public AudioClip woosh = null;

	
	void Update () 
	{
		Rotate();
		Throw();
	}

	void Rotate()
	{
		if (Input.GetKey (KeyCode.LeftArrow))
        {
            this.transform.Rotate (new Vector3 (0, -rotateSpeed * Time.deltaTime, 0));
        }
        else if (Input.GetKey (KeyCode.RightArrow))
        {
            this.transform.Rotate (new Vector3 (0, rotateSpeed * Time.deltaTime, 0));
		}
		if (Input.GetKey (KeyCode.UpArrow))
        {
            this.transform.Rotate (new Vector3 (-rotateSpeed * Time.deltaTime, 0, 0));
        }
        else if (Input.GetKey (KeyCode.DownArrow))
        {
            this.transform.Rotate (new Vector3 (rotateSpeed * Time.deltaTime, 0, 0));
		}            
	}

	void Throw()
	{

		if (Input.GetKeyDown(KeyCode.Space))
		{	
			MeshRenderer m =cone.GetComponent<MeshRenderer>();
         	m.enabled = false;
			MeshRenderer m2 =line.GetComponent<MeshRenderer>();
         	m2.enabled = false;
			this.GetComponent<Rigidbody>().useGravity = true;
			this.GetComponent<Rigidbody>().AddForce(transform.forward*force);
			GetComponent<AudioSource>().PlayOneShot(woosh);


		}

		if (Input.GetKey(KeyCode.Return))
		{
			ResetBall();
		}

	}

	void ResetBall()
	{
		Debug.Log("Return ball");
		this.transform.position = new Vector3(0,.55f,-6);
		transform.rotation = Quaternion.identity;
		MeshRenderer m =cone.GetComponent<MeshRenderer>();
		m.enabled=true;
		MeshRenderer m2 =line.GetComponent<MeshRenderer>();
		m2.enabled=true;

	}
}