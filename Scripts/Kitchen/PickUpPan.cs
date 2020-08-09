using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpPan : MonoBehaviour
{
	private GameObject[] Pans;
	private GameObject[] OnPlayerPans;
	
	public static GameObject currentPan;
	public GameObject PutPanTrigger;
	

	public static GameObject currentPanOnPlayer;
	public static int index;
	
	public AudioSource GetStuffSound;

	public float distanceToInteract = 8f;
	public float distanceToObject;
	
    public GameObject ActionDisplay;
    public GameObject ActionText;
    public GameObject NormalCross;
    public GameObject InteractCross;
    
    	
	void Start()
	{
		Pans = GameObject.FindGameObjectsWithTag("Pan");
		OnPlayerPans = GameObject.FindGameObjectsWithTag("OnPlayerPan");
		index = Random.Range(0, Pans.Length);
		currentPan = Pans[index];
		currentPanOnPlayer = OnPlayerPans[index];
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
            ActionText.GetComponent<Text>().text = "Get a pan";
            ActionDisplay.SetActive(true);
            ActionText.SetActive(true);
        }

        if (Input.GetButtonDown("Action"))
        {
            if (distanceToObject <= distanceToInteract)
            {
                this.GetComponent<BoxCollider>().enabled = false;
				currentPan.SetActive(false);
				currentPanOnPlayer.GetComponent<MeshRenderer>().enabled = true;
                ActionDisplay.SetActive(false);
                ActionText.SetActive(false);
                GetStuffSound.Play();
                InteractCross.SetActive(false);
                NormalCross.SetActive(true);
				PutPanTrigger.SetActive(true);
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
