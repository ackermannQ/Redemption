using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JumpScare007 : MonoBehaviour
{
	
	public AudioSource MonsterGrowl;
	public AudioSource ExplosionSound;
	
	public GameObject KidTrigger1;
	public GameObject TextBox;
	 
    private void OnTriggerEnter(Collider col)
    {
        GetComponent<BoxCollider>().enabled = false;
        MonsterGrowl.Play();
		ExplosionSound.Play();
		
		KidTrigger1.SetActive(true);
		StartCoroutine(ScenePlayer());
    }
	
	 IEnumerator ScenePlayer()
    {
		GetComponent<BoxCollider>().enabled = false;
        TextBox.GetComponent<Text>().text = "What the hell was that ?!";
		yield return new WaitForSeconds(2f);
		TextBox.GetComponent<Text>().text = "It came from the entrance gate";
		
		yield return new WaitForSeconds(2f);
		TextBox.GetComponent<Text>().text = "";

		
    }
}
