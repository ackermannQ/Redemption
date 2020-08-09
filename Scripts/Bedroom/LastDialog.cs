using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LastDialog : MonoBehaviour
{
    public AudioSource EmotionSound;
	
    public GameObject Soul;
	public GameObject TextBox;
	public GameObject Louise;


    private void OnTriggerEnter(Collider col)
    {
        GetComponent<BoxCollider>().enabled = false;
		//EmotionSound.Play();
		StartCoroutine(Dialog());
		
    }
	
	IEnumerator Dialog()
	{
		Louise.SetActive(true);
		TextBox.SetActive(true);
		yield return new WaitForSeconds(1.4f);
		TextBox.GetComponent<Text>().text = "You have to forgive yourself";
		yield return new WaitForSeconds(2f);
		TextBox.GetComponent<Text>().text = "It was not your fault";
		yield return new WaitForSeconds(3f);
		TextBox.GetComponent<Text>().text = "Deep down, you feel the darkness you have been inhabited with";
		yield return new WaitForSeconds(3f);
		TextBox.GetComponent<Text>().text = "The one that lead you in this place";
		yield return new WaitForSeconds(2f);
		TextBox.GetComponent<Text>().text = "You can chose to leave. You have to. We are waiting for you";
		yield return new WaitForSeconds(4f);
		TextBox.GetComponent<Text>().text = "Find the pieces of your soul";
		yield return new WaitForSeconds(2f);
		TextBox.GetComponent<Text>().text = "See you soon, love";
		yield return new WaitForSeconds(2f);
		TextBox.GetComponent<Text>().text = "";
		Soul.SetActive(true);
		Louise.SetActive(false);
		
	}

}
