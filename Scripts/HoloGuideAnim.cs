using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoloGuideAnim : MonoBehaviour
{
	
	public GameObject HoloGuide;
	public GameObject HoloGuideTrigger;
	
	public Animator anim;
	
	//public AudioSource WhiteNoise;
		
    private void OnTriggerEnter()
    {
        //WhiteNoise.Play();
        StartCoroutine(MoveHologuide());
		//WhiteNoise.Stop();
    }
	
	IEnumerator MoveHologuide(){
		HoloGuide.SetActive(true);
		yield return new WaitForSeconds(0.1f);
		HoloGuide.SetActive(false);
		HoloGuide.transform.position +=  new Vector3(5, 0, 0);
		HoloGuide.SetActive(true);
		yield return new WaitForSeconds(0.1f);
		HoloGuide.SetActive(false);
		HoloGuide.transform.position +=  new Vector3(5, 0, 0);
		HoloGuide.SetActive(true);
		yield return new WaitForSeconds(0.1f);
		HoloGuide.SetActive(false);
		HoloGuide.transform.position +=  new Vector3(5, 0, 0);
		HoloGuide.SetActive(true);
		yield return new WaitForSeconds(0.1f);
		HoloGuide.SetActive(false);
		HoloGuide.transform.position +=  new Vector3(5, 0, 0);
		HoloGuide.SetActive(true);
		yield return new WaitForSeconds(0.1f);
		HoloGuide.SetActive(false);
		HoloGuide.transform.position +=  new Vector3(5, 0, 0);
		HoloGuide.SetActive(true);
		yield return new WaitForSeconds(0.1f);
		HoloGuide.SetActive(false);
		HoloGuide.transform.position +=  new Vector3(20, 0, 0);
		HoloGuide.SetActive(true);
		yield return new WaitForSeconds(0.1f);
		HoloGuide.SetActive(false);
	}
}
