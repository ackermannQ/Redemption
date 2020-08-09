using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trap : MonoBehaviour
{
    public AudioSource MovingWall;
	
    public GameObject Wall;
	public GameObject Text;
	public GameObject Drawing;

    private void OnTriggerEnter(Collider col)
    {
        GetComponent<BoxCollider>().enabled = false;
		StartCoroutine(PlayerTalk());
        MovingWall.Play();
		Wall.GetComponent<Animation>().Play("ClosingLivingRoomAnim");
        Drawing.SetActive(true);
    }
	
	IEnumerator PlayerTalk()
	{
		Text.GetComponent<Text>().text = "It's our livingroom ...";
		yield return new WaitForSeconds(1f);
		Text.GetComponent<Text>().text = "";
	}
	
}
