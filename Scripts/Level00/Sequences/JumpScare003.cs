using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScare003 : MonoBehaviour
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
        yield return new WaitForSeconds(0.2f);
        JumpScare.SetActive(false);
    }
}
