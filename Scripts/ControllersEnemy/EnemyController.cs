using UnityEngine.AI;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float lookRadius = 10f;

    Transform target;
    NavMeshAgent agent;

    public Animator anim;

    void Start()
    {
		if (PlayerManager.instance.player.transform != null){
			target = PlayerManager.instance.player.transform;
			agent = GetComponent<NavMeshAgent>();
		}
       }

    void Update()
    {
        float distance = Vector3.Distance(target.position, transform.position);
        anim.SetBool("isPlayerClose", false);
        anim.SetBool("isWalking", false);
        anim.SetBool("Attack", false);
        anim.SetBool("TriggerDeath", false);

        if (distance <= lookRadius){
            agent.SetDestination(target.position);
            anim.SetBool("isPlayerClose", true);
        }
		
		if (distance <= agent.stoppingDistance){
            anim.SetBool("isPlayerClose", true);
            FaceTarget();
		}
    }

    void OnTriggerEnter(Collider col)
    {
        anim.SetBool("isWalking", false);
        anim.SetBool("isPlayerClose", true);
        anim.SetBool("Attack", true);
    }

    void OnTriggerExit(Collider col)
    {
        anim.SetBool("isWalking", true);
        anim.SetBool("isPlayerClose", false);
        anim.SetBool("Attack", false);
    }

    void FaceTarget(){
		Vector3 direction = (target.position - transform.position).normalized;
		Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
		transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5f);	
	}

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRadius);
    }
}
