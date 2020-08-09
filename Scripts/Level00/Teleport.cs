using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform teleportTarget;
	public GameObject ThePlayer;
	
	void OnTriggerEnter(Collider col)
	{
		Debug.Log("Actual Player pos : "+ThePlayer.transform.position);
		Debug.Log("Position targeted : "+teleportTarget.transform.position);
		ThePlayer.transform.position = teleportTarget.transform.position;
		Debug.Log("Teleported");
		Debug.Log("Actual Player pos : "+ThePlayer.transform.position);
		Debug.Log("Position targeted : "+teleportTarget.transform.position);
	}
	
}
