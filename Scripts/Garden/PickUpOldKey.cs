using UnityEngine.UI;
using UnityEngine;

public class PickUpOldKey : MonoBehaviour
{
	public static bool GotRustedKey = false;
	
    public float distanceToObject;
	public float distanceToInteract = 5f;
	
    public GameObject ActionDisplay;
    public GameObject ActionText;
    public GameObject RustedKey;
	public GameObject MonsterTrigger;
	public GameObject Maze;
	
	public static bool deactivateMaze = false;
	
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
            ActionText.GetComponent<Text>().text = "Get the rusted key";
            ActionDisplay.SetActive(true);
            ActionText.SetActive(true);
        }

        if (Input.GetButtonDown("Action"))
        {
            if (distanceToObject <= distanceToInteract)
            {
				CraftingRecipe.SoulKey = true; // Because Inventory is broken for now
                this.GetComponent<BoxCollider>().enabled = false;
                ActionText.GetComponent<Text>().text = "";
				ActionDisplay.SetActive(false);
                ActionText.SetActive(false);
                GetStuffSound.Play();
                RustedKey.SetActive(false);
                InteractCross.SetActive(false);
				NormalCross.SetActive(true);
				GotRustedKey = true;
				MonsterTrigger.SetActive(true);
				deactivateMaze = true;
				Maze.SetActive(false);
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
