using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpPaste : MonoBehaviour
{
	public GameObject Paste;
	public GameObject PutPasteTrigger;
	public GameObject PasteOnPlayer;
	
	public AudioSource GetStuffSound;

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
            ActionText.GetComponent<Text>().text = "Get the pancake paste\nI should put it next to the cooker";
            ActionDisplay.SetActive(true);
            ActionText.SetActive(true);
        }

        if (Input.GetButtonDown("Action"))
        {
            if (distanceToObject <= distanceToInteract)
            {
                this.GetComponent<BoxCollider>().enabled = false;
				Paste.SetActive(false);
				PasteOnPlayer.SetActive(true);
                ActionDisplay.SetActive(false);
                ActionText.SetActive(false);
                GetStuffSound.Play();
                InteractCross.SetActive(false);
                NormalCross.SetActive(true);
				PutPasteTrigger.SetActive(true);
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
