using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScare006 : MonoBehaviour
{
    public AudioSource whispersSound;
	public AudioSource lighteningSound;
	
    public GameObject JumpScareObject1;
	public GameObject JumpScareObject2;
	public GameObject JumpScareObject3;
	public GameObject Balloons;
	public GameObject Lightening;
	public GameObject JumpTrigger7;
	
	public Animation BalloonsAnim;

	public float counter = 0.225f;
	 
    private void OnTriggerEnter(Collider col)
    {
        GetComponent<BoxCollider>().enabled = false;
        
        StartCoroutine(Wait());
        
    }

    IEnumerator Wait()
    {
		whispersSound.Play();
		yield return new WaitForSeconds(2f);
		JumpScareObject1.SetActive(true);
		JumpScareObject2.SetActive(true);
		JumpScareObject3.SetActive(true);
		JumpTrigger7.SetActive(true);
		Balloons.SetActive(true);
		Balloons.GetComponent<Animation>().Play("BalloonsMovingAnim");
		Lightening.SetActive(true);
		lighteningSound.Play();
		Lightening.GetComponent<Animation>().Play("LigteningAnim");
		
		while (counter >= 0.1f){
			whispersSound.volume = whispersSound.volume - 0.025f;
			yield return new WaitForSeconds(1f);			
		}
		
		whispersSound.Stop();
		
    }
}
