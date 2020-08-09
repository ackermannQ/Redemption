using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMusic : MonoBehaviour
{
	
	public GameObject Music;
	 
    private void OnTriggerEnter(Collider col)
    {
		Music.SetActive(true);
        
    }

}
