using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayObservatory : MonoBehaviour
{
	
    public GameObject Painting;
	public GameObject Observatory;
	public GameObject HumanWall;
	public GameObject WallClosePath;
	public GameObject InObsTrigger;
	

    private void OnTriggerEnter()
    {
        GetComponent<BoxCollider>().enabled = false;
		Painting.SetActive(false);
		HumanWall.SetActive(false);
		Observatory.SetActive(true);
		WallClosePath.SetActive(true);
		InObsTrigger.SetActive(true);
    }

}
