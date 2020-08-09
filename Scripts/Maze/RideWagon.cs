using UnityEngine.UI;
using UnityEngine;

public class RideWagon : MonoBehaviour
{
    public float distanceToObject;
	public float distanceToInteract = 8f;
	
	public GameObject ThePlayer;
    public GameObject ActionDisplay;
    public GameObject ActionText;
	public GameObject Wagon;

	public Animation PlayerMovingInWagon;
	public Animation WagonMoving;
	
	public AudioSource MovingWagonSound;
 
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
            ActionText.GetComponent<Text>().text = "Should be faster than walking ...";
            ActionDisplay.SetActive(true);
            ActionText.SetActive(true);
        }

        if (Input.GetButtonDown("Action"))
        {
			if (distanceToObject <= distanceToInteract)
			{
				this.GetComponent<BoxCollider>().enabled = false;
				ActionDisplay.SetActive(false);
				ActionText.SetActive(false);
				ThePlayer.GetComponent<Animation>().Play("GetIntoWagonAnim");
				//WagonMoving.Play("MovingWagonAnim");
				
				InteractCross.SetActive(false);
				NormalCross.SetActive(true);
				//MovingWagon.Play();
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
