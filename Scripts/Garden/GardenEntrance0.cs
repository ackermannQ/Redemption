using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GardenEntrance0 : MonoBehaviour
{
	
	public GameObject Music;
	 
    private void OnTriggerEnter(Collider col)
    {
		Music.SetActive(true);
        
    }

}
