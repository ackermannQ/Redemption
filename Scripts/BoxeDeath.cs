using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxeDeath : MonoBehaviour
{
    public int EnemyHealth = 20;
	public GameObject TheEnemy;
	public int StatusCheck;
	
	public bool TriggerDeath = false;
	
	
	void DamageZombie(int DamageAmount)
	{
		EnemyHealth -= DamageAmount;
		Debug.Log(EnemyHealth);
	}
	
	void Update()
    {
        if (EnemyHealth <= 0 && StatusCheck == 0)
		{
			Debug.Log(EnemyHealth);
			StatusCheck = 2;
			TriggerDeath = true;
		}
    }
}
