using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GiveSoap : MonoBehaviour
{
	public GameObject OnPlayerSoap;
	public GameObject BloodBath;
	
	public AudioSource GetStuffSound;
	public AudioSource KillSound;

	public float distanceToInteract = 8f;
	public float distanceToObject;
	
    public GameObject ActionDisplay;
    public GameObject ActionText;
    public GameObject NormalCross;
    public GameObject InteractCross;

	public GameObject MarthaText;
	public GameObject Text;
	
	public GameObject MarthaBath;
	
	public GameObject Monster;
	public GameObject BrickWall;
	public GameObject BlockingWall;
	public GameObject Demon;
    
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
            ActionText.GetComponent<Text>().text = "Give the soap to Martha";
            ActionDisplay.SetActive(true);
            ActionText.SetActive(true);
        }

        if (Input.GetButtonDown("Action"))
        {
            if (distanceToObject <= distanceToInteract)
            {
                this.GetComponent<BoxCollider>().enabled = false;
				OnPlayerSoap.SetActive(false);
                ActionDisplay.SetActive(false);
                ActionText.SetActive(false);
                GetStuffSound.Play();
                InteractCross.SetActive(false);
                NormalCross.SetActive(true);
				StartCoroutine(KillMartha());
            }
        }
    }
	
	IEnumerator KillMartha()
	{
		yield return new WaitForSeconds(1f);
		MarthaText.GetComponent<Text>().text = "Thank you honey";
		yield return new WaitForSeconds(2f);
		MarthaText.GetComponent<Text>().text = "";
		yield return new WaitForSeconds(1f);
		MarthaText.GetComponent<Text>().text = "Is everything ok ? I find you a bit pale";
		yield return new WaitForSeconds(2f);
		MarthaText.GetComponent<Text>().text = "";
		Monster.SetActive(true);
		yield return new WaitForSeconds(3f);
		Monster.SetActive(false);
		KillSound.Play();
		BloodBath.SetActive(true);
		MarthaBath.SetActive(false);
		BlockingWall.SetActive(false);
		BrickWall.SetActive(false);
		Demon.SetActive(true);
		yield return new WaitForSeconds(0.5f);
		Demon.SetActive(false);
		
	}
	
    private void OnMouseExit()
    {
        ActionDisplay.SetActive(false);
        ActionText.SetActive(false);
        InteractCross.SetActive(false);
        NormalCross.SetActive(true);
    }


}
