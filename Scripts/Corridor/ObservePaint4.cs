using UnityEngine.UI;
using UnityEngine;

public class ObservePaint4 : MonoBehaviour
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
            Text.GetComponent<Text>().text = "Such a creepy nun ...";
			

        }

    }
	
    private void OnMouseExit()
    {
        InteractCross.SetActive(false);
        NormalCross.SetActive(true);
		Text.GetComponent<Text>().text = "";
    }
}
