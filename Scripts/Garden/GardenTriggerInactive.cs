using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GardenTriggerInactive : MonoBehaviour
{
	public GameObject TriggerSoundGarden;
	
    public GameObject CricketsSound;
	public GameObject RainWindSound;

    private void OnTriggerEnter(Collider col)
    {
		this.GetComponent<BoxCollider>().enabled = false;
        RainWindSound.SetActive(false);
		CricketsSound.SetActive(false);
		TriggerSoundGarden.SetActive(true);
    }
	
	
}
