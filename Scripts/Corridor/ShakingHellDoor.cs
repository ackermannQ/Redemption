using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakingHellDoor : MonoBehaviour
{
	
	public GameObject HellDoor;
	//public GameObject Monster;
	
	public AudioSource RattleSound;
	public AudioSource HelpmeSound;
	public AudioSource DamnedSound;
	//public AudioSource MonsterSound;
	

    private void OnTriggerEnter()
    {
        GetComponent<BoxCollider>().enabled = false;
		RattleSound.Play();
		HellDoor.GetComponent<Animation>().Play("ShakingHellDoorAnim");
		StartCoroutine(DamnedSoulSound());
    }
	
	IEnumerator DamnedSoulSound(){
		yield return new WaitForSeconds(1f);
		HelpmeSound.Play();
		yield return new WaitForSeconds(3f);
		DamnedSound.Play();
		//MonsterSound.Play(); // I'm behind you 
	}

}
