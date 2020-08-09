using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InObsTrigger : MonoBehaviour
{
	
	public GameObject MonsterTrigger;
	public GameObject Text;
	

    private void OnTriggerEnter()
    {
        GetComponent<BoxCollider>().enabled = false;
		MonsterTrigger.SetActive(true);
		StartCoroutine(Speaking());
    }
	
	IEnumerator Speaking(){
		Text.GetComponent<Text>().text = "Who has been watching me ?!";
		yield return new WaitForSeconds(3f);
		Text.GetComponent<Text>().text = "";
	}

}
