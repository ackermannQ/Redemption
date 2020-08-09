using System.Collections;
using UnityEngine;
using UnityEngine.UI;


public class ReactionTrigger : MonoBehaviour
{
    public GameObject TextBox;
	
	private void OnTriggerEnter()
    {
        StartCoroutine(ScenePlayer());
    }

    IEnumerator ScenePlayer()
    {
		GetComponent<BoxCollider>().enabled = false;
        TextBox.GetComponent<Text>().text = "What the hell was that ?!";
		yield return new WaitForSeconds(2f);
		TextBox.GetComponent<Text>().text = "";

		
    }
}
