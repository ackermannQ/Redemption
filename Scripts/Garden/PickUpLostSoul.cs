using UnityEngine.UI;
using UnityEngine;

public class PickUpLostSoul : MonoBehaviour
{
	public static bool GotLostSoul = false;
	
    public float distanceToObject;
	public float distanceToInteract = 5f;
	
    public GameObject ActionDisplay;
    public GameObject ActionText;
    public GameObject LostSoul;
	
    public AudioSource GetStuffSound;
 
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
            ActionText.GetComponent<Text>().text = "Grab the lost soul";
            ActionDisplay.SetActive(true);
            ActionText.SetActive(true);
        }

        if (Input.GetButtonDown("Action"))
        {
            if (distanceToObject <= distanceToInteract)
            {
                this.GetComponent<BoxCollider>().enabled = false;
                ActionText.GetComponent<Text>().text = "";
				ActionDisplay.SetActive(false);
                ActionText.SetActive(false);
                GetStuffSound.Play();
                LostSoul.SetActive(false);
                InteractCross.SetActive(false);
				NormalCross.SetActive(true);
				GotLostSoul = true;
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
