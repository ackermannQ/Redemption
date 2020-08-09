using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class LightTrigger : MonoBehaviour
{	
	
	public GameObject Light;
	public GameObject Radiographies;
	
	public AudioSource Music;
	public AudioSource BuzzingLightSound;
	
	public Animation anim;
	
    private void OnTriggerEnter(Collider col)
    {
		this.GetComponent<BoxCollider>().enabled = false;
		StartCoroutine(LightAnim());
    }
	
	IEnumerator LightAnim()
	{
		yield return new WaitForSeconds(30f);
		Radiographies.SetActive(true);
		Music.Stop();
		BuzzingLightSound.Play();
		anim.Play("WelcomeRoomLightBuzzing");
	}
	

}
