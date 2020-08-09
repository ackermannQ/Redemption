using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterTrigger : MonoBehaviour
{
	
    public GameObject ClosingWall;
	public GameObject Deactivate1;
	public GameObject Deactivate2;
	public GameObject Deactivate3;

    private void OnTriggerEnter()
    {
        GetComponent<BoxCollider>().enabled = false;
		ClosingWall.SetActive(true);
		Deactivate1.SetActive(false);
		Deactivate2.SetActive(false);
		//Deactivate3.SetActive(false);
    }

}
