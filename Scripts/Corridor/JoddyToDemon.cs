using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JoddyToDemon : MonoBehaviour
{
	
	public GameObject Monster;
	public GameObject Joddy;
	public GameObject Text;
	

    private void OnTriggerEnter()
    {
        GetComponent<BoxCollider>().enabled = false;
		StartCoroutine(Speaking());
    }
	
	IEnumerator Speaking(){
		Text.GetComponent<Text>().text = "Hello ?";
		yield return new WaitForSeconds(1.5f);
		Text.GetComponent<Text>().text = "Are you alright ? What is this place ?";
		yield return new WaitForSeconds(2f);
		Text.GetComponent<Text>().text = "Something is wrong with her..";
		yield return new WaitForSeconds(2f);
		Joddy.SetActive(false);
		Monster.SetActive(true);
		yield return new WaitForSeconds(0.5f);
		Joddy.SetActive(true);
		Monster.SetActive(false);
		yield return new WaitForSeconds(1f);
		Joddy.SetActive(false);
		Monster.SetActive(true);
		yield return new WaitForSeconds(0.5f);
		Text.GetComponent<Text>().text = "I'm going crazy";
		Joddy.SetActive(true);
		Monster.SetActive(false);
		
		for(int i = 0; i < 25; i++) { 
			yield return new WaitForSeconds(0.5f);
			Joddy.SetActive(false);
			Monster.SetActive(true);
			yield return new WaitForSeconds(1f);
			Text.GetComponent<Text>().text = "";
			Joddy.SetActive(true);
			Monster.SetActive(false);
			yield return new WaitForSeconds(0.5f);
		}
		
	}

}
