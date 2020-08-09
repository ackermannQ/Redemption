using System.Collections;
using UnityEngine;
using UnityEngine.UI;


public class WeirdLaughtTrigger : MonoBehaviour
{
    public GameObject TextBox;
	
	public AudioSource ScarySound;
	
	private void OnTriggerEnter()
    {
        StartCoroutine(ScenePlayer());
    }

    IEnumerator ScenePlayer()
    {
		GetComponent<BoxCollider>().enabled = false;
		ScarySound.Play();
		yield return new WaitForSeconds(2f);
        TextBox.GetComponent<Text>().text = "I need to go on";
		yield return new WaitForSeconds(2f);
		TextBox.GetComponent<Text>().text = "";
		
		ScarySound.Stop();
		
    }
}
