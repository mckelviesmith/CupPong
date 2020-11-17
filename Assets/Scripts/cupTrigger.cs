using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cupTrigger : MonoBehaviour 
{
public GameObject cupT=null;
public GameObject cup;
public AudioClip bounce = null;

	
	void OnTriggerEnter(Collider other)
	{
		if (cupT==null)
		{
			GetComponent<AudioSource>().PlayOneShot(bounce);
			cup.GetComponent<Renderer>().enabled=false;
			//cupT.SetActive(true);
			cupT=null;
			Debug.Log("Ball in cup");
			DestroyTrig();
		}
	}

	void DestroyTrig()
	{
		if (Input.GetKey(KeyCode.Return))
		{
			Debug.Log("Trigger Destroyed");
			Destroy(cupT);
		}
	}
} 