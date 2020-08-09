using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnterDemonExperimentRoom : MonoBehaviour
{	
	
	public GameObject Text;
	

	
    private void OnTriggerEnter(Collider col)
    {
		this.GetComponent<BoxCollider>().enabled = false;
		Text.GetComponent<Text>().text = "What the fuck is this doomed place ?";
	}
	

}
