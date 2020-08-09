using UnityEngine.UI;
using UnityEngine;

public class HumanExpRoom : MonoBehaviour
{
	public static bool Key = false;
	
    public float distanceToObject;
	public float distanceToInteract = 5f;
	
    public GameObject ActionDisplay;
    public GameObject ActionText;
    public GameObject TheKey;
	
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
            ActionText.GetComponent<Text>().text = "Get the key";
            ActionDisplay.SetActive(true);
            ActionText.SetActive(true);
        }

        if (Input.GetButtonDown("Action"))
        {
            if (distanceToObject <= distanceToInteract)
            {
				Key = true; // Because Inventory is broken for now
                this.GetComponent<BoxCollider>().enabled = false;
                ActionText.GetComponent<Text>().text = "";
				ActionDisplay.SetActive(false);
                ActionText.SetActive(false);
                GetStuffSound.Play();
                TheKey.SetActive(false);
                InteractCross.SetActive(false);
				NormalCross.SetActive(true);
				Key = true;
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
