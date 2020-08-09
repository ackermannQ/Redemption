using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorBlocked : MonoBehaviour
{
	public GameObject Door;

	public float distanceToObject;
    public GameObject ActionDisplay;
    public GameObject ActionText;
    public GameObject NormalCross;
    public GameObject InteractCross;
    
    void Update()
    {
        distanceToObject = PlayerCasting.DistanceFromTarget;
    }

    private void OnMouseOver()
    {
        if (distanceToObject <= 10f)
        {
            NormalCross.SetActive(false);
            InteractCross.SetActive(true);
            ActionText.GetComponent<Text>().text = "It's locked";
            ActionDisplay.SetActive(true);
            ActionText.SetActive(true);
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
