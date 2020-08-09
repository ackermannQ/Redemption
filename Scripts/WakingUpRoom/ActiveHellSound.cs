using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActiveHellSound : MonoBehaviour
{
    public AudioSource HellSound;
	
    public GameObject HellSoundTrigger;

    private void OnTriggerEnter(Collider col)
    {
        GetComponent<BoxCollider>().enabled = false;
		HellSound.Play();
		HellSoundTrigger.GetComponent<BoxCollider>().enabled = true;
    }
	
	
}
