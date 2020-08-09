using UnityEngine.UI;
using UnityEngine;

public class ActivationLever : MonoBehaviour
{
	
    public float distanceToObject;
	public float distanceToInteract = 5f;
	
    public GameObject ActionDisplay;
    public GameObject ActionText;
    
    public AudioSource LeverMovingSound;
 
    public GameObject NormalCross;
    public GameObject InteractCross;
	public GameObject WayOutWall;
	
	public Animation anim;

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
            ActionText.GetComponent<Text>().text = "Activate";
            ActionDisplay.SetActive(true);
            ActionText.SetActive(true);

			if (Input.GetButtonDown("Action"))
			{
				if (distanceToObject <= distanceToInteract)
				{
					this.GetComponent<BoxCollider>().enabled = false;
					ActionText.GetComponent<Text>().text = "";
					ActionDisplay.SetActive(false);
					ActionText.SetActive(false);
					InteractCross.SetActive(false);
					NormalCross.SetActive(true);
					anim.Play();
					WayOutWall.SetActive(false);
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
    }
}
