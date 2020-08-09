using UnityEngine;

public class ZombieDeath : MonoBehaviour
{
    public static int EnemyHealth = 20;
	public GameObject TheEnemy;
	public int StatusCheck;
	
	public Animator anim;
	public GameObject MonsterSound;
	public GameObject DyingSound;
	
	public static bool TriggerDeath = false;
	
	
	void DamageZombie(int DamageAmount)
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
			anim.SetBool("isRunning", false);
			anim.SetBool("isAttacking", false);
			anim.SetBool("TriggerDeath", true);
			MonsterSound.SetActive(false);
			DyingSound.SetActive(true);
			GameObject.Find("ZombieRig").GetComponent<ZombieAI>().enabled = false;
			
		}
    }
	
}
