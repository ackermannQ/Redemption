using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PancakeSequenceTrigger : MonoBehaviour
{	
	
	public GameObject Light;
	public GameObject Paints;
	public GameObject Question;


    private void OnTriggerEnter(Collider col)
    {
		this.GetComponent<BoxCollider>().enabled = false;
		Light.SetActive(true);
		Paints.SetActive(true);
		Question.SetActive(true);

	}
	

}
