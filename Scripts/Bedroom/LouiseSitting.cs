using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LouiseSitting : MonoBehaviour
{
	
	public GameObject LouiseSit;
	public GameObject LouiseSad;
	 
    private void OnTriggerEnter(Collider col)
    {
        GetComponent<BoxCollider>().enabled = false;
        StartCoroutine(Wait());
        
    }

    IEnumerator Wait()
    {
		LouiseSit.SetActive(true);
		yield return new WaitForSeconds(5f);
		LouiseSit.SetActive(false);
		yield return new WaitForSeconds(2f);
		LouiseSad.SetActive(true);
		yield return new WaitForSeconds(10f);
		LouiseSad.SetActive(false);
    }
}
