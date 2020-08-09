using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ReadArticle : MonoBehaviour
{
    public float distanceToObject;
    public float distanceRequired = 2f;

    public GameObject ActionDisplay;
    public GameObject ActionText;
    public GameObject FakeArticle;
	public GameObject OnPlayerArticle;
    public AudioSource GetStuffsound;
    public GameObject NormalCross;
    public GameObject InteractCross;

    void Update()
    {
        distanceToObject = PlayerCasting.DistanceFromTarget;
		if (Input.GetKey(KeyCode.X))
		{
			FakeArticle.SetActive(true);
			OnPlayerArticle.SetActive(false);
		}
    }

    private void OnMouseOver()
    {
        if (distanceToObject <= distanceRequired)
        {
            NormalCross.SetActive(false);
            InteractCross.SetActive(true);
            ActionDisplay.SetActive(true);
            ActionText.SetActive(true);
			ActionText.GetComponent<Text>().text = "Read the article";
        }

        if (Input.GetButtonDown("Action"))
        {
            if (distanceToObject <= distanceRequired)
            {
				//this.GetComponent<BoxCollider>().enabled = false;
				ActionDisplay.SetActive(false);
				ActionText.SetActive(false);
				FakeArticle.SetActive(false);
				OnPlayerArticle.SetActive(true);
				GetStuffsound.Play();
				ActionText.GetComponent<Text>().text = "";
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
