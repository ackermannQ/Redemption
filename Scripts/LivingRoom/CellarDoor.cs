using UnityEngine.UI;
using UnityEngine;

public class CellarDoor : MonoBehaviour
{
    public float distanceToObject;
    public float distanceRequired = 5f;

    public GameObject ActionDisplay;
    public GameObject ActionText;
    public GameObject Door;
    public AudioSource OpeningDoor;
    public GameObject NormalCross;
    public GameObject InteractCross;

    void Update()
    {
        distanceToObject = PlayerCasting.DistanceFromTarget;
    }

    private void OnMouseOver()
    {
        if (distanceToObject <= distanceRequired)
        {
            NormalCross.SetActive(false);
            InteractCross.SetActive(true);
            ActionDisplay.SetActive(true);
            ActionText.SetActive(true);
			ActionText.GetComponent<Text>().text = "I need a key";
        }

        if (Input.GetButtonDown("Action"))
        {
            if (distanceToObject <= distanceRequired)
            {
				if (PickUpCellarKey.GotCellarKey == true){
					ActionText.GetComponent<Text>().text = "Open the door";
					this.GetComponent<BoxCollider>().enabled = false;
					ActionDisplay.SetActive(false);
					ActionText.SetActive(false);
					Door.GetComponent<Animation>().Play("OpeningCellar");
					OpeningDoor.Play();
					ActionText.GetComponent<Text>().text = "";
					PickUpCellarKey.GotCellarKey = false;
					
				} else {
					ActionText.GetComponent<Text>().text = "I need a key";
				}
            }
        }
    }
    private void OnMouseExit()
    {
        ActionDisplay.SetActive(false);
        ActionText.SetActive(false);
        InteractCross.SetActive(false);
        NormalCross.SetActive(true);
		ActionText.GetComponent<Text>().text = "";
    }
}
