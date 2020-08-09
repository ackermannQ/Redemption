using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LittleMonsterTrigger : MonoBehaviour
{
	public AudioSource MonsterSound;
	public GameObject Monster;
	 
    private void OnTriggerEnter(Collider col)
    {
        GetComponent<BoxCollider>().enabled = false;
       
		StartCoroutine(ScenePlayer());
    }
	
	 IEnumerator ScenePlayer()
    {
		GetComponent<BoxCollider>().enabled = false;
        Monster.SetActive(true);
		//MonsterSound.Play();
		yield return new WaitForSeconds(0.4f);
		Monster.SetActive(false);
    }
}
