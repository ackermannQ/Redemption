using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeactivateHellSound : MonoBehaviour
{
    public AudioSource HellSound;
	public AudioSource AmbianceMusic;
	
    public GameObject HellSoundTrigger;

    private void OnTriggerEnter(Collider col)
    {
        GetComponent<BoxCollider>().enabled = false;
		HellSound.Stop();
		HellSoundTrigger.GetComponent<BoxCollider>().enabled = true;
		AmbianceMusic.Play();
    }
	
	
}
