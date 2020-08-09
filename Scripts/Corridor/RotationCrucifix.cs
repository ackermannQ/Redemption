using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotationCrucifix : MonoBehaviour
{
	
	public GameObject Crucifix;
	public GameObject Text;
	public GameObject Close1;
	public GameObject Close2;
	public GameObject Close3;
	public GameObject CloseWayBack;
	public GameObject MonsterCrawling;
	

    private void OnTriggerEnter()
    {
		
        GetComponent<BoxCollider>().enabled = false;
		StartCoroutine(Speaking());
		Close1.SetActive(false);
		Close2.SetActive(false);
		Close3.SetActive(false);
		CloseWayBack.SetActive(true);
    }
	
	IEnumerator Speaking(){
		Text.GetComponent<Text>().text = "Is he praying ?";
		yield return new WaitForSeconds(1f);
		MonsterCrawling.SetActive(true);
		Crucifix.GetComponent<Animation>().Play("CrucifixAnil");
		yield return new WaitForSeconds(2f);
		Text.GetComponent<Text>().text = "I have to find a way out";
		yield return new WaitForSeconds(2f);
		Text.GetComponent<Text>().text = "";
		MonsterCrawling.SetActive(false);
	}

}
