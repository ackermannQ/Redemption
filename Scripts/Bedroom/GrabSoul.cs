using UnityEngine.UI;
using UnityEngine;

public class GrabSoul : MonoBehaviour
{
	
    public float distanceToObject;
	public float distanceToInteract = 5f;
	
    public GameObject ActionDisplay;
    public GameObject ActionText;
	public GameObject PieceOfSoul;
 
    public GameObject NormalCross;
    public GameObject InteractCross;
	
	public GameObject Music;
	
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
            ActionText.GetComponent<Text>().text = "Collect a piece of your soul\nIt's the end ... For now ;)";
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
					PieceOfSoul.SetActive(false);
					Music.SetActive(true);
					
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
