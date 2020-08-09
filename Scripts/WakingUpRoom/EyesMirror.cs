using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class EyesMirror : MonoBehaviour
{	
    public float distanceToObject;
	public float distanceToInteract = 2f;
	
	public GameObject Eyes;
	
	
    void Update()
    {
        distanceToObject = PlayerCasting.DistanceFromTarget;
    }

    private void OnTriggerEnter(Collider col)
    {
		this.GetComponent<BoxCollider>().enabled = false;
		StartCoroutine(ShortTime());
    }
	
	IEnumerator ShortTime()
	{
		yield return new WaitForSeconds(1f);
		Eyes.SetActive(true);
		yield return new WaitForSeconds(0.2f);
		Eyes.SetActive(false);
	}
	

}
