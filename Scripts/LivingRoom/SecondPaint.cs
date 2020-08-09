using UnityEngine.UI;
using UnityEngine;

public class SecondPaint : MonoBehaviour
{	
    public float distanceToObject;
	public float distanceToInteract = 6f;
	
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
            Text.GetComponent<Text>().text = "I remember this day at the park. James was just born..";
			
        }

    }
	
    private void OnMouseExit()
    {
        InteractCross.SetActive(false);
        NormalCross.SetActive(true);
		Text.GetComponent<Text>().text = "";
    }
}
