using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PutPanOnCooker : MonoBehaviour
{
	public static GameObject OnCookerPan;
	
	public GameObject PasteTrigger;
	
	public AudioSource PutPanThereSound;

	public float distanceToInteract = 8f;
	public float distanceToObject;
	
	public int index;
	
    public GameObject ActionDisplay;
    public GameObject ActionText;
    public GameObject NormalCross;
    public GameObject InteractCross;
	
	void Start()
	{
		
		OnCookerPan = GameObject.Find(PickUpPan.currentPan.name);
		
	}
    
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
            ActionText.GetComponent<Text>().text = "Put pan on cooker";
            ActionDisplay.SetActive(true);
            ActionText.SetActive(true);
        }

        if (Input.GetButtonDown("Action"))
        {
            if (distanceToObject <= distanceToInteract)
            {
                this.GetComponent<BoxCollider>().enabled = false;
				PickUpPan.currentPanOnPlayer.GetComponent<MeshRenderer>().enabled = false;
				OnCookerPan.GetComponent<MeshRenderer>().enabled = true;
                ActionDisplay.SetActive(false);
                ActionText.SetActive(false);
                PutPanThereSound.Play();
                InteractCross.SetActive(false);
                NormalCross.SetActive(true);
				PasteTrigger.SetActive(true);
				
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
