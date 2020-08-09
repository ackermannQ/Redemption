using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CutScene01 : MonoBehaviour
{
	
	public GameObject thePlayer;
	public GameObject cutSceneCamera;
	
	
	void Start(){
		cutSceneCamera.SetActive(true);
		thePlayer.SetActive(false);
		StartCoroutine(EndCutScene());
	}
	
	IEnumerator EndCutScene()
	{
		yield return new WaitForSeconds(10);
		thePlayer.SetActive(true);
		cutSceneCamera.SetActive(false);
	
	}
	
	
}
