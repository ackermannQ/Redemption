using UnityEngine.UI;
using UnityEngine;

public class ObservePaint1 : MonoBehaviour
{	
    public float distanceToObject;
	public float distanceToInteract = 3f;
	
	public GameObject Text;
 
    public GameObject NormalCross;
    public GameObject InteractCross;
	
	public GameObject Chair1;
	public GameObject Chair2;

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
            Text.GetComponent<Text>().text = "It's a map of Hell from Dante's Inferno";
			
			if (Chair1.active){
				Chair1.SetActive(false);
				Chair2.SetActive(true);
			}

        }

    }
	
    private void OnMouseExit()
    {
        InteractCross.SetActive(false);
        NormalCross.SetActive(true);
		Text.GetComponent<Text>().text = "";
    }
}
