using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KidRunningLiving : MonoBehaviour
{
	
	public GameObject KidRunning;
	public AudioSource KidLaugh;

	 
    private void OnTriggerEnter(Collider col)
    {
        KidLaugh.Play();
		StartCoroutine(Wait());

    }
	
	IEnumerator Wait(){
		KidRunning.SetActive(true);
		yield return new WaitForSeconds(1f);
		KidRunning.SetActive(false);
		gameObject.SetActive(false);
	}
}
