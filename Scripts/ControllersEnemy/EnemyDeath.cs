using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyDeath : MonoBehaviour
{
	[SerializeField]
	public static int EnemyHealth = 200;
	
	public GameObject TheEnemy;
	public int StatusCheck;

	public Animator anim;
	public AudioSource MonsterSound;

	public static bool TriggerDeath = false;


	void DamageMonster(int DamageAmount)
	{
		EnemyHealth -= DamageAmount;
	}

	void Start()
	{
		anim = GetComponent<Animator>();
	}

	void Update()
	{
		if (EnemyHealth <= 0 && StatusCheck == 0)
		{
			StatusCheck = 2;
			anim.SetBool("isWalking", false);
			anim.SetBool("TriggerDeath", true);
			//GameObject.Find("ZombieLastRoom").GetComponent<ZombieAI>().enabled = false;
		}
	}

}
