using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PutPancakesPlate : MonoBehaviour
{
	public GameObject PancakesPlateOnPlayer;
	public GameObject PancakesPlateOnTable;
	
	public AudioSource PlacingPlateSound;
	public AudioSource ThankYouSound;
	public AudioSource CutSound;
	public AudioSource ChairFall;

	public float distanceToInteract = 8f;
	public float distanceToObject;
	
    public GameObject ActionDisplay;
    public GameObject ActionText;
    public GameObject NormalCross;
    public GameObject InteractCross;
	public GameObject TextBox;
	
	public GameObject BeforeObject1;
    public GameObject BeforeObject2;
	public GameObject AfterObject1;
    public GameObject AfterObject2;
	public GameObject Chair;
	public GameObject BlockingWall;
	public GameObject Light;
	public GameObject ThankYou;
	public GameObject WouldYou;
	public GameObject BathrooomEntranceTrigger;
	
	public GameObject BrickWall;
	
    
    void Update()
    {
        distanceToObject = PlayerCasting.DistanceFromTarget;
    }

    private void OnMouseOver()
    {
        if (distanceToObject <= distanceToInteract)
        {
            NormalCross.SetActive(false);
            InteractCross.SetActive(true);
            ActionText.GetComponent<Text>().text = "Give the pancakes to James";
            ActionDisplay.SetActive(true);
            ActionText.SetActive(true);
        }

        if (Input.GetButtonDown("Action"))
        {
            if (distanceToObject <= distanceToInteract)
            {
                this.GetComponent<BoxCollider>().enabled = false;
				PancakesPlateOnPlayer.SetActive(false);
				PancakesPlateOnTable.SetActive(true);
                ActionDisplay.SetActive(false);
                ActionText.SetActive(false);
                PlacingPlateSound.Play();
                InteractCross.SetActive(false);
                NormalCross.SetActive(true);
				StartCoroutine(KillChildSequence());
            }
        }
    }
    private void OnMouseExit()
    {
        ActionDisplay.SetActive(false);
        ActionText.SetActive(false);
        InteractCross.SetActive(false);
        NormalCross.SetActive(true);
    }
	
	IEnumerator  KillChildSequence()
	{
		ThankYouSound.Play();
		yield return new WaitForSeconds(2f);
		CutSound.Play();
		yield return new WaitForSeconds(5f);
		ChairFall.Play();
		yield return new WaitForSeconds(2f);
		Light.SetActive(false);
		BeforeObject1.SetActive(false);
		BeforeObject2.SetActive(false);
		AfterObject1.SetActive(true);
		AfterObject2.SetActive(true);
		Chair.SetActive(true);
		BlockingWall.SetActive(false);
		WouldYou.SetActive(false);
		ThankYou.SetActive(true);
		yield return new WaitForSeconds(2f);
		TextBox.GetComponent<Text>().text = "I think Martha is in her bath";
		BathrooomEntranceTrigger.SetActive(true);
		yield return new WaitForSeconds(2f);
		TextBox.GetComponent<Text>().text = "";
	}

}
