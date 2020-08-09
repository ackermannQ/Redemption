using System.Collections;
using UnityEngine;

public class ZombieAI : MonoBehaviour
{
	public GameObject ThePlayer;
	public GameObject TheEnemy;
	public GameObject TheFlash;
	
	public float EnemySpeed = 0.005f;
	
	public bool isRunning = true;
	public bool attackTrigger = false;
	public bool isAttacking = false;
	
	public AudioSource hurtSound1;
	public AudioSource hurtSound2;
	public AudioSource hurtSound3;
	
	public int hurtGen;
	
	public Animator anim;
	
    void Update()
    {
        transform.LookAt(ThePlayer.transform.position - new Vector3(0, 3, 2));
		anim.SetBool("TriggerDeath", false);

		if (attackTrigger == false)
			{
			EnemySpeed = 0.005f;
			anim.SetBool("isAttacking", false);
			anim.SetBool("isRunning", true);
			transform.position = Vector3.MoveTowards(transform.position, ThePlayer.transform.position, EnemySpeed);
		}
		
		if (attackTrigger == true && isAttacking == false)
		{
			EnemySpeed = 0;
			StartCoroutine(InflictDamage());
			anim.SetBool("isAttacking", false);
		}
    }
	
	void OnTriggerEnter(Collider col){
		anim.SetBool("isRunning", false);
		anim.SetBool("isAttacking", true);
		attackTrigger = true;
	}
	
	void OnTriggerExit(Collider col)
	{
		anim.SetBool("isRunning", true);
		anim.SetBool("isAttacking", false);
		attackTrigger = false;
	}
	
	IEnumerator InflictDamage(){
		isAttacking = true;
		yield return new WaitForSeconds(1.1f);
		hurtGen = Random.Range(1,5);
		if (hurtGen == 1){
			hurtSound1.Play();
		}
		
		if (hurtGen == 2){
			hurtSound2.Play();
		}
		
		if (hurtGen == 3){
			hurtSound3.Play();
		}
		
		TheFlash.SetActive(true);
		yield return new WaitForSeconds(0.1f); // Check if value ok or need to be changed
		TheFlash.SetActive(false);
		yield return new WaitForSeconds(1.1f);
		GlobalHealth.currentHealth -= 5;
		yield return new WaitForSeconds(2f);
		isAttacking = false;
	}
}
