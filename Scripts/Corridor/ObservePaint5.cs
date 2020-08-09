using UnityEngine.UI;
using UnityEngine;

public class ObservePaint5 : MonoBehaviour
{	
    public float distanceToObject;
	public float distanceToInteract = 8f;
	
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
            Text.GetComponent<Text>().text = "What a hellish view.\nWill I look like this if I stay here ?";
			

        }

    }
	
    private void OnMouseExit()
    {
        InteractCross.SetActive(false);
        NormalCross.SetActive(true);
		Text.GetComponent<Text>().text = "";
    }
}
