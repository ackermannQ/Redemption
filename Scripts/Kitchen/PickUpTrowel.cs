using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpTrowel : MonoBehaviour
{
	public GameObject Trowel;
	public GameObject UseTrowelTrigger;
	public GameObject TrowelOnPlayer;
	
	public AudioSource GetStuffSound;

	public float distanceToInteract = 15f;
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
            ActionText.GetComponent<Text>().text = "Get the trowel";
            ActionDisplay.SetActive(true);
            ActionText.SetActive(true);
        }

        if (Input.GetButtonDown("Action"))
        {
            if (distanceToObject <= distanceToInteract)
            {
                this.GetComponent<BoxCollider>().enabled = false;
				Trowel.SetActive(false);
				TrowelOnPlayer.SetActive(true);
                ActionDisplay.SetActive(false);
                ActionText.SetActive(false);
                GetStuffSound.Play();
                InteractCross.SetActive(false);
                NormalCross.SetActive(true);
				UseTrowelTrigger.SetActive(true);
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
