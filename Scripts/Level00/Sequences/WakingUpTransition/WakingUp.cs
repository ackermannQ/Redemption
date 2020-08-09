using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WakingUp : MonoBehaviour
{
	public Animation anim;
	public AudioSource IseeYou;

    void Start()
    {
        anim.Play();
		StartCoroutine(PlayGame());
    }

	IEnumerator PlayGame()
    {
		yield return new WaitForSeconds(2f);
		IseeYou.Play();
		yield return new WaitForSeconds(10f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
