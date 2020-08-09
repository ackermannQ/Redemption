using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovingGround : MonoBehaviour
{
    public GameObject TextBox;
	public Animator FirstMovingGroundAnim;
	public AudioSource GroundMoving;
	
	public GameObject Maze;
	public GameObject HExpRoom;
	public GameObject DExpRoom;
	
	
	private void OnTriggerEnter(Collider col)
    {
        StartCoroutine(ScenePlayer());
    }

    IEnumerator ScenePlayer()
    {
		GetComponent<BoxCollider>().enabled = false;
		GroundMoving.Play();
		FirstMovingGroundAnim.SetBool("isActive", true);
        TextBox.GetComponent<Text>().text = "WHAT THE HELL ?!";
		yield return new WaitForSeconds(1f);
		TextBox.GetComponent<Text>().text = "";
		FirstMovingGroundAnim.SetBool("isActive", false);
		HExpRoom.SetActive(false);
		DExpRoom.SetActive(false);
		Maze.SetActive(true);


	}
}
