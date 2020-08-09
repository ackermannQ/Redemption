using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UseTrowel : MonoBehaviour
{	
	public AudioSource Bloubloup;

	public float distanceToInteract = 8f;
	public float distanceToObject;
	
    public GameObject ActionDisplay;
    public GameObject ActionText;
    public GameObject NormalCross;
    public GameObject InteractCross;
	
	public GameObject Pancake1;
	public GameObject Pancake2;
	public GameObject Pancake3;
	public GameObject Pancake4;
	
	public GameObject TrowelOnPlayer;
	public GameObject GrabPlateTrigger;
    
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
            ActionText.GetComponent<Text>().text = "Do the pancake";
            ActionDisplay.SetActive(true);
            ActionText.SetActive(true);
        }

        if (Input.GetButtonDown("Action"))
        {
            if (distanceToObject <= distanceToInteract)
            {
                this.GetComponent<BoxCollider>().enabled = false;
				PutPanOnCooker.OnCookerPan.transform.Find("Pancake").GetComponent<MeshRenderer>().enabled = true;
                ActionDisplay.SetActive(false);
                ActionText.SetActive(false);
                //Bloubloup.Play();
                InteractCross.SetActive(false);
                NormalCross.SetActive(true);
				StartCoroutine(PancakesMade());
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
	
		IEnumerator PancakesMade()
	{
		yield return new WaitForSeconds(1.2f);
		Pancake1.SetActive(true);
		yield return new WaitForSeconds(1.5f);
		Pancake2.SetActive(true);
		yield return new WaitForSeconds(2f);
		Pancake3.SetActive(true);
		yield return new WaitForSeconds(1f);
		Pancake4.SetActive(true);
		TrowelOnPlayer.SetActive(false);
		GrabPlateTrigger.SetActive(true);
	}

}
