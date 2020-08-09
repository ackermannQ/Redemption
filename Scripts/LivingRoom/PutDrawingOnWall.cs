using UnityEngine.UI;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PutDrawingOnWall : MonoBehaviour
{	
    public float distanceToObject;
	public float distanceToInteract = 5f;
	
    public GameObject ActionDisplay;
    public GameObject ActionText;
	public GameObject Text;
    public GameObject FakeDrawing;
	public GameObject RealDrawing;
	public GameObject Wall;
	public GameObject OnPlayerDrawing;
	
	public AudioSource MovingWall;
    public AudioSource GetGunSound;
 
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
            Text.GetComponent<Text>().text = "It's a draw from James. We used to be happy.";
            ActionDisplay.SetActive(true);
            ActionText.SetActive(true);
			if (PickUpDrawing.GotDrawing == true){
				ActionText.GetComponent<Text>().text = "Replace";
			} else {
				ActionText.GetComponent<Text>().text = "";
			}
        }

        if (Input.GetButtonDown("Action"))
        {
			if (PickUpDrawing.GotDrawing == true){
				if (distanceToObject <= distanceToInteract)
				{
					this.GetComponent<MeshCollider>().enabled = false;
					ActionDisplay.SetActive(false);
					ActionText.SetActive(false);
					GetGunSound.Play();
					FakeDrawing.SetActive(false);
					RealDrawing.SetActive(true);
					OnPlayerDrawing.SetActive(false);
					InteractCross.SetActive(false);
					NormalCross.SetActive(true);
					Wall.GetComponent<Animation>().Play("OpeningLivingRoomAnim");
					MovingWall.Play();
					Text.GetComponent<Text>().text = "";
				} 
            } else {
					StartCoroutine(Realization());
				}
        }
    }
	
    private void OnMouseExit()
    {
        ActionDisplay.SetActive(false);
        ActionText.SetActive(false);
        InteractCross.SetActive(false);
        NormalCross.SetActive(true);
		Text.GetComponent<Text>().text = "";
    }
	
	IEnumerator Realization()
	{
		ActionText.GetComponent<Text>().text = "It reminds me of something";
		yield return new WaitForSeconds(2f);
		ActionText.GetComponent<Text>().text = "";
		Text.GetComponent<Text>().text = "";
	}
}
