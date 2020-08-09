using UnityEngine.UI;
using UnityEngine;

public class ObserveWritings1 : MonoBehaviour
{	
    public float distanceToObject;
	public float distanceToInteract = 30f;
	
	public GameObject Text;
 
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
            Text.GetComponent<Text>().text = "It's written : Abandon all hope ye who enter here.\nHow do I read this ?";
        }

    }
	
    private void OnMouseExit()
    {
        InteractCross.SetActive(false);
        NormalCross.SetActive(true);
		Text.GetComponent<Text>().text = "";
    }
}
