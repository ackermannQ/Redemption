using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class SetLever : MonoBehaviour
{	

	public GameObject Lever;
	
    private void OnTriggerEnter(Collider col)
    {
		this.GetComponent<BoxCollider>().enabled = false;
		Lever.SetActive(true);
	}

}
