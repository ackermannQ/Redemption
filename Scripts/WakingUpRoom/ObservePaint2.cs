using UnityEngine.UI;
using UnityEngine;

public class ObservePaint2 : MonoBehaviour
{	
    public float distanceToObject;
	public float distanceToInteract = 2f;
	
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
            Text.GetComponent<Text>().text = "A representation of hell, poor choice of decorating";
			
			if (Chair2.active){
				Chair1.SetActive(true);
				Chair2.SetActive(false);
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
