using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClimbingLadder : MonoBehaviour
{
	public float distanceToObject;
	public float distanceToInteract = 2f;
	
    public AudioSource ClimbingLadderSound;
	public AudioSource BreathingEffort;
	
    public GameObject ClimbingTrigger;
	public GameObject ActionText;
	public GameObject Text;
	public GameObject ActionDisplay;
	public GameObject Player;
	public GameObject NormalCross;
    public GameObject InteractCross;

	private void Update()
	{
		distanceToObject = PlayerCasting.DistanceFromTarget;
	}
	
    private void OnMouseOver()
    {
		if (distanceToObject <= distanceToInteract)
        {
            ActionDisplay.SetActive(true);
            NormalCross.SetActive(false);
            InteractCross.SetActive(true);
            ActionText.GetComponent<Text>().text = "Climb";
			ActionText.SetActive(true);
			
			if (Input.GetButtonDown("Action"))
			{
				if (distanceToObject <= distanceToInteract && OpenTrappe.isHatchOpen == true)
				{
					this.GetComponent<BoxCollider>().enabled = false;
					ActionText.GetComponent<Text>().text = "";
					ActionDisplay.SetActive(false);
					ActionText.SetActive(false);
					InteractCross.SetActive(false);
					NormalCross.SetActive(true);
					//ClimbingLadderSound.Play();
					//BreathingEffort.Play();
					Player.GetComponent<Animation>().Play("ClimbingLadderAnim");
				} else {
					StartCoroutine(WaitingTime());
				}
			}
		}
	}
			
	private void OnMouseExit()
    {
		this.GetComponent<BoxCollider>().enabled = true;
		ActionText.GetComponent<Text>().text = "";
		Text.GetComponent<Text>().text = "";
        ActionDisplay.SetActive(false);
        ActionText.SetActive(false);
        InteractCross.SetActive(false);
        NormalCross.SetActive(true);
		
    }
	
	
	IEnumerator WaitingTime()
	{
		Text.GetComponent<Text>().text = "I should open the hatch first";
		yield return new WaitForSeconds(3f);
		ActionText.GetComponent<Text>().text = "";
		
	}
	
}
