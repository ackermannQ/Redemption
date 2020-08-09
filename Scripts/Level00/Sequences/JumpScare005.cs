using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScare005 : MonoBehaviour
{
    public AudioSource JumpScareMusic;
    public GameObject JumpScare;


    private void OnTriggerEnter(Collider col)
    {
        GetComponent<BoxCollider>().enabled = false;
        JumpScareMusic.Play();
        StartCoroutine(Wait());
        
    }

    IEnumerator Wait()
    {
        JumpScare.SetActive(true);
        yield return new WaitForSeconds(2f);
        JumpScare.SetActive(false);
    }
}
