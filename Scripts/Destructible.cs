using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructible : MonoBehaviour
{
	public GameObject destroyedVersion;
	
	public AudioSource breakSound;
	
	void OnMouseDown()
	{
		Instantiate(destroyedVersion, transform.position, transform.rotation);
		breakSound.Play();
		// BreakBoxIndication script needs deactivation
		Destroy(gameObject);
	}

}