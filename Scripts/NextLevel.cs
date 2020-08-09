using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
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
            ActionDisplay.SetActive(true);
            ActionText.SetActive(true);
        }

        if (Input.GetButtonDown("Action"))
        {
            if (distanceToObject <= 10f)
            {
                this.GetComponent<BoxCollider>().enabled = false;
                ActionDisplay.SetActive(false);
                ActionText.SetActive(false);
                InteractCross.SetActive(false);
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                
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
