using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisappearAgonyDemon : MonoBehaviour
{	
	
	public GameObject Demon;
	public GameObject Text;
	
	public int counterX = 0;
	
    private void OnTriggerEnter(Collider col)
    {
		this.GetComponent<BoxCollider>().enabled = false;
		Demon.SetActive(false);
		Debug.Log("Add a sound when the demon disappear, and 2 sec later the following sentence");
		Text.GetComponent<Text>().text = "Was that a demon ?";
	}
	

}
