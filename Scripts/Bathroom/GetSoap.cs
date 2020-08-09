using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetSoap : MonoBehaviour
{
	public GameObject Soap;
	public GameObject OnPlayerSoap;
	
	public AudioSource GetStuffSound;

	public float distanceToInteract = 8f;
	public float distanceToObject;
	
    public GameObject ActionDisplay;
    public GameObject ActionText;
    public GameObject NormalCross;
    public GameObject InteractCross;
	
	public GameObject GiveSoapTrigger;
	
    
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
            ActionText.GetComponent<Text>().text = "Pick up the soap";
            ActionDisplay.SetActive(true);
            ActionText.SetActive(true);
        }

        if (Input.GetButtonDown("Action"))
        {
            if (distanceToObject <= distanceToInteract)
            {
                this.GetComponent<BoxCollider>().enabled = false;
				Soap.SetActive(false);
				OnPlayerSoap.SetActive(true);
                ActionDisplay.SetActive(false);
                ActionText.SetActive(false);
                GetStuffSound.Play();
                InteractCross.SetActive(false);
                NormalCross.SetActive(true);
				GiveSoapTrigger.SetActive(true);
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


}
