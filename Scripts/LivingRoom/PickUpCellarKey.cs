using UnityEngine.UI;
using UnityEngine;

public class PickUpCellarKey : MonoBehaviour
{	
    public float distanceToObject;
	public float distanceToInteract = 5f;
	
	public static bool GotCellarKey = false;
	
    public GameObject ActionDisplay;
    public GameObject ActionText;
    public GameObject CellarKey;
	
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
            ActionText.GetComponent<Text>().text = "Get the cellar key";
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
                CellarKey.SetActive(false);
                InteractCross.SetActive(false);
				NormalCross.SetActive(true);
				GotCellarKey = true;
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
