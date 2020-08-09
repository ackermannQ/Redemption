using System.Collections;
using UnityEngine;
using UnityEngine.UI;


public class WeirdRoomTrigger : MonoBehaviour
{
    public GameObject ThePlayer;
    public GameObject TextBox;
	
	public AudioSource NormalAmbiance;
	public AudioSource ScarySound;
	
	public static bool isWeirdRoomTriggerActive = false;
	
	public float counter = 0.225f;
	
	private void OnTriggerEnter()
    {
        StartCoroutine(ScenePlayer());
    }

    IEnumerator ScenePlayer()
    {
		isWeirdRoomTriggerActive = true;
		ScarySound.Play();
		yield return new WaitForSeconds(3f);
		NormalAmbiance.Stop();
        yield return new WaitForSeconds(3f);
        TextBox.GetComponent<Text>().text = "Is it upside-down ?!";
		NormalAmbiance.Play();
		yield return new WaitForSeconds(2f);
		TextBox.GetComponent<Text>().text = "It looks like an experiment room";
		yield return new WaitForSeconds(3f);
		TextBox.GetComponent<Text>().text = "";
		while (counter >= 0.1f){
			ScarySound.volume = ScarySound.volume - 0.025f;
			yield return new WaitForSeconds(1f);			
		}
		
		ScarySound.Stop();
		gameObject.SetActive(false);
		
    }
}
