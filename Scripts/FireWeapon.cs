using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireWeapon : MonoBehaviour
{
	public Camera fpsCam;
	
    public GameObject Muzzle;
	
	[SerializeField]
	private GameObject _bulletHolePrefab;
	
	public AudioSource Gunfire;
	
	public bool isFiring = false;
	
	public float targetDistance;
	
	public int DamageAmount = 20;
	
	void Update()
	{
		if (Input.GetButtonDown("Fire1") && GlobalAmmo.AmmoCount >= 1)
		{
			if (isFiring == false){
				GlobalAmmo.AmmoCount -= 1;
				Muzzle.SetActive(true);
				StartCoroutine(FiringWeapon());
			}
		}
		
		IEnumerator FiringWeapon() 
		{
			RaycastHit Shot;
			isFiring = true;
			if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out Shot))
			{
				if (Shot.collider.tag == "Wall" || Shot.collider.tag == "Roof" || Shot.collider.tag == "Ground"){
					//Instantiate(_bulletHolePrefab, Shot.point, Quaternion.LookRotation(Shot.normal));
					//Instantiate(_bulletHolePrefab, Shot.point, Quaternion.AngleAxis(Random.Range(0f,360f), Shot.normal) * Quaternion.LookRotation(Shot.normal));
					Instantiate(_bulletHolePrefab, Shot.point, Quaternion.AngleAxis(Random.Range(0f,90f), Shot.normal) * Quaternion.LookRotation(Shot.normal));
				}
				
				if (Shot.collider.tag == "Roof" || Shot.collider.tag == "Ground"){
					Instantiate(_bulletHolePrefab, Shot.point, Quaternion.AngleAxis(Random.Range(90f, 180f), Shot.normal) * Quaternion.LookRotation(Shot.normal));
				}
				
				/*if (Shot.collider.tag == "Demon"){
					Instantiate(_bulletHolePrefab, Shot.point, Quaternion.AngleAxis(Random.Range(90f, 180f), Shot.normal) * Quaternion.LookRotation(Shot.normal));
				}*/
			
				targetDistance = Shot.distance;
				Shot.transform.SendMessage("DamageMonster", DamageAmount, SendMessageOptions.DontRequireReceiver);
			}
			
			Muzzle.SetActive(true);
			Gunfire.Play();
			yield return new WaitForSeconds(0.15f);
			Muzzle.SetActive(false);
			isFiring = false;
		}
	}
}
