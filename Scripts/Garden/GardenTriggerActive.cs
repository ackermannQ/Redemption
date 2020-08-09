using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GardenTriggerActive : MonoBehaviour
{
	
    public GameObject CricketsSound;
	public GameObject RainWindSound;
	public GameObject LivingMusic;

    private void OnTriggerEnter(Collider col)
    {
		this.GetComponent<BoxCollider>().enabled = false;
        RainWindSound.SetActive(true);
		CricketsSound.SetActive(true);
		LivingMusic.SetActive(false);
    }
	
	
}
