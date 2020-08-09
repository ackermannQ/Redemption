using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BathroomEntrance : MonoBehaviour
{	
	public GameObject PreviousLight;
	public GameObject Light;
	public GameObject BrickWall;
	public GameObject BloodBath;
	public GameObject Soap;
	
	
	public GameObject MarthaText;
	public GameObject Text;
	
	public GameObject MarthaBath;
	
    private void OnTriggerEnter(Collider col)
    {
		this.GetComponent<BoxCollider>().enabled = false;
		PreviousLight.SetActive(true);
		BrickWall.SetActive(true);
		Light.SetActive(true);
		StartCoroutine(Sequence());
	}
	
	IEnumerator Sequence()
	{
		
		yield return new WaitForSeconds(1f);
		MarthaText.GetComponent<Text>().text = "Is everything alright ?";
		yield return new WaitForSeconds(1f);
		MarthaText.GetComponent<Text>().text = "I heard some noise";
		yield return new WaitForSeconds(1f);
		MarthaText.GetComponent<Text>().text = "";
		yield return new WaitForSeconds(1f);
		Text.GetComponent<Text>().text = "James moved his chair too loud";
		yield return new WaitForSeconds(2.5f);
		Text.GetComponent<Text>().text = "";
		yield return new WaitForSeconds(1f);
		MarthaText.GetComponent<Text>().text = "Alright";
		yield return new WaitForSeconds(1f);
		MarthaText.GetComponent<Text>().text = "";
		yield return new WaitForSeconds(1f);
		Text.GetComponent<Text>().text = "Do you need something ?";
		yield return new WaitForSeconds(2f);
		Text.GetComponent<Text>().text = "";
		yield return new WaitForSeconds(1f);
		MarthaText.GetComponent<Text>().text = "Could you get me the soap please ?";
		yield return new WaitForSeconds(2f);
		MarthaText.GetComponent<Text>().text = "";
		Soap.SetActive(true);
		yield return new WaitForSeconds(1f);
		Text.GetComponent<Text>().text = "Sure";
		yield return new WaitForSeconds(1f);
		Text.GetComponent<Text>().text = "";
		MarthaBath.SetActive(true);

	}
	

}
