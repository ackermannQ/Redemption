using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterGarden : MonoBehaviour
{
    public AudioSource EnjoyKill;
	
	public GameObject FirstBoss;
	 
    private void OnTriggerEnter(Collider col)
    {
        GetComponent<BoxCollider>().enabled = false;
        StartCoroutine(Wait());
        
    }

    IEnumerator Wait()
    {
		EnjoyKill.Play();
		yield return new WaitForSeconds(1f);
		FirstBoss.SetActive(true);
		yield return new WaitForSeconds(5f);
		FirstBoss.SetActive(false);
		
    }
}
