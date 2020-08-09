using UnityEngine.UI;
using UnityEngine;

public class ObserveWritings2 : MonoBehaviour
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
            Text.GetComponent<Text>().text = "It's written : Use their fear, they will be ours forever";
        }

    }
	
    private void OnMouseExit()
    {
        InteractCross.SetActive(false);
        NormalCross.SetActive(true);
		Text.GetComponent<Text>().text = "";
    }
}
