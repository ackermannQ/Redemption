using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PutPaste : MonoBehaviour
{
	public GameObject PasteOnPlayer;
	public GameObject PasteOnTable;
	public GameObject Trowel;
	public GameObject TextBox;
	
	public AudioSource PutPasteHere;
	public AudioSource FallingTrowelOnGroundSound;

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
            ActionText.GetComponent<Text>().text = "Put the paste here";
            ActionDisplay.SetActive(true);
            ActionText.SetActive(true);
        }

        if (Input.GetButtonDown("Action"))
        {
            if (distanceToObject <= distanceToInteract)
            {
                this.GetComponent<BoxCollider>().enabled = false;
				PasteOnTable.SetActive(true);
				PasteOnPlayer.SetActive(false);
                ActionDisplay.SetActive(false);
                ActionText.SetActive(false);
				PutPasteHere.Play();
                InteractCross.SetActive(false);
                NormalCross.SetActive(true);
				StartCoroutine(SoundTrowel());
				Trowel.SetActive(true);
            }
        }
    }
	
	IEnumerator SoundTrowel()
	{
		yield return new WaitForSeconds(2f);
		Trowel.SetActive(true);
		FallingTrowelOnGroundSound.Play();
		TextBox.GetComponent<Text>().text = "What was that ?! it came from the bathroom...";
		yield return new WaitForSeconds(2f);
		TextBox.GetComponent<Text>().text = "";
	}
	
    private void OnMouseExit()
    {
        ActionDisplay.SetActive(false);
        ActionText.SetActive(false);
        InteractCross.SetActive(false);
        NormalCross.SetActive(true);
    }

}
