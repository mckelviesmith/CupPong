using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundEffect : MonoBehaviour {

	public GameObject cup=null;
	public GameObject table=null;
	public AudioClip bounce=null;

	void OnTriggerEnter(Collider other)
	{
		if (cup==null)
		{
			GetComponent<AudioSource>().PlayOneShot(bounce);
		}
		
	}
}