using UnityEngine.UI;
using UnityEngine;

public class FirstPaint : MonoBehaviour
{	
    public float distanceToObject;
	public float distanceToInteract = 5f;
	
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
            Text.GetComponent<Text>().text = "What happened ? Our faces are riped off";

        }

    }
	
    private void OnMouseExit()
    {
        InteractCross.SetActive(false);
        NormalCross.SetActive(true);
		Text.GetComponent<Text>().text = "";
    }
}
