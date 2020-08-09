using UnityEngine.UI;
using UnityEngine;

public class PickUpDrawing : MonoBehaviour
{
	public static bool GotDrawing = false;
	
    public float distanceToObject;
	public float distanceToInteract = 5f;
	
    public GameObject ActionDisplay;
    public GameObject ActionText;
    public GameObject Drawing;
	public GameObject OnPlayerDrawing;
	
	public GameObject ExploseDoor;
	
    public AudioSource GetGunSound;
 
    public GameObject NormalCross;
    public GameObject InteractCross;

	public GameObject ReactionTrigger;
	
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
            ActionText.GetComponent<Text>().text = "It's a draw from James";
            ActionDisplay.SetActive(true);
            ActionText.SetActive(true);
        }

        if (Input.GetButtonDown("Action"))
        {
            if (distanceToObject <= distanceToInteract)
            {
                this.GetComponent<MeshCollider>().enabled = false;
                ActionDisplay.SetActive(false);
                ActionText.SetActive(false);
                GetGunSound.Play();
				ExploseDoor.SetActive(false);
                Drawing.SetActive(false);
				OnPlayerDrawing.SetActive(true);
                InteractCross.SetActive(false);
				NormalCross.SetActive(true);
				ReactionTrigger.SetActive(true);
				GotDrawing = true;
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
