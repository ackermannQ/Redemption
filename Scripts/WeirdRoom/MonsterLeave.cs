using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterLeave : MonoBehaviour
{
	public GameObject MakerDemon;

    public AudioSource MonsterSound;

    public Animator anim;

	
    private void OnTriggerEnter(Collider col)
	{
		StartCoroutine(MonsterLeaving());
	}
	
	IEnumerator MonsterLeaving()
	{
		this.GetComponent<BoxCollider>().enabled = false;
		yield return new WaitForSeconds(5f);
		MonsterSound.Play();
		MakerDemon.SetActive(false);
	}
}
