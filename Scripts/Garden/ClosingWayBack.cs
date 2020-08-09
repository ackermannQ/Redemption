using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosingWayBack : MonoBehaviour
{	
	
	public GameObject ClosingWall;
	
	public AudioSource Crack;

	
    private void OnTriggerEnter(Collider col)
    {
		this.GetComponent<BoxCollider>().enabled = false;
		ClosingWall.SetActive(true);
		//Crack.Play();
	}
	

}
