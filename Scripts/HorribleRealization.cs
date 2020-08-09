using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorribleRealization : MonoBehaviour
{
    public GameObject HorribleRealizationSound;
	 
    private void OnTriggerEnter(Collider col)
    {
        GetComponent<BoxCollider>().enabled = false;
        
        HorribleRealizationSound.SetActive(true);
        
    }
}
