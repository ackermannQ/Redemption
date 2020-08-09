using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShakingDoorTrigger : MonoBehaviour
{
    public AudioSource DoorShaking;
	public AudioSource ChaseMusic;
	
    public GameObject Door;
	public GameObject TextBox;
	
	public GameObject TriggerDoor;

    private void OnTriggerEnter()
    {
        GetComponent<BoxCollider>().enabled = false;
		DoorShaking.Play();
        Door.GetComponent<Animation>().Play("CreepyDoorShakingAnim");
		StartCoroutine(ActiveTrigger());
		
    }
	
	IEnumerator ActiveTrigger()
	{
		yield return new WaitForSeconds(1.4f);
		ChaseMusic.Play();
		TextBox.GetComponent<Text>().text = "I NEED TO HIDE";
		yield return new WaitForSeconds(8f);
		ChaseMusic.Stop();
		yield return new WaitForSeconds(1.3f);
		TextBox.GetComponent<Text>().text = "I think it's gone";
		yield return new WaitForSeconds(1f);
		TextBox.GetComponent<Text>().text = "";
		TriggerDoor.SetActive(true);
		TriggerDoor.GetComponent<BoxCollider>().enabled = true;
		
	}

}
