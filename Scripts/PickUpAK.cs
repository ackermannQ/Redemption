using UnityEngine.UI;
using UnityEngine;

public class PickUpAK : MonoBehaviour
{
    public float distanceToObject;
    public GameObject ActionDisplay;
    public GameObject ActionText;
    public GameObject FakeAK;
    public AudioSource GetGunSound;
    public GameObject RealAK;
    public GameObject GuideArrow;
    public GameObject NormalCross;
    public GameObject InteractCross;
    public GameObject TheJumpTrigger;

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
            ActionText.GetComponent<Text>().text = "Pick up the weapon";
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
                GetGunSound.Play();
                FakeAK.SetActive(false);
                RealAK.SetActive(true);
                InteractCross.SetActive(false);
                GuideArrow.SetActive(false);
				TheJumpTrigger.SetActive(true);
                
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
