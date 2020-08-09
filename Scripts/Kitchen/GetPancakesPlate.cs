using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetPancakesPlate : MonoBehaviour
{
	public GameObject PancakesPlate;
	public GameObject PutPancakesPlateOnTableTrigger;
	public GameObject PancakesPlateOnPlayer;
	public GameObject Light;
	
	public AudioSource GetStuffSound;
	public AudioSource GiggleKid;

	public float distanceToInteract = 8f;
	public float distanceToObject;
	
    public GameObject ActionDisplay;
    public GameObject ActionText;
    public GameObject NormalCross;
    public GameObject InteractCross;

	
    
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
            ActionText.GetComponent<Text>().text = "Pick up the plate";
            ActionDisplay.SetActive(true);
            ActionText.SetActive(true);
        }

        if (Input.GetButtonDown("Action"))
        {
            if (distanceToObject <= distanceToInteract)
            {
                this.GetComponent<BoxCollider>().enabled = false;
				PancakesPlate.SetActive(false);
				PancakesPlateOnPlayer.SetActive(true);
                ActionDisplay.SetActive(false);
                ActionText.SetActive(false);
                GetStuffSound.Play();
                InteractCross.SetActive(false);
                NormalCross.SetActive(true);
				PutPancakesPlateOnTableTrigger.SetActive(true);
				Light.SetActive(true);
				StartCoroutine(Laugh());
            }
        }
    }
	
	IEnumerator Laugh()
	{
		yield return new WaitForSeconds(1.4f);
		GiggleKid.Play();
	}
	
    private void OnMouseExit()
    {
        ActionDisplay.SetActive(false);
        ActionText.SetActive(false);
        InteractCross.SetActive(false);
        NormalCross.SetActive(true);
    }


}
