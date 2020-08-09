using UnityEngine.UI;
using UnityEngine;

public class FakeWall : MonoBehaviour
{
    public float distanceToObject;
    public float distanceRequired = 2f;

    public GameObject ActionDisplay;
    public GameObject ActionText;
	public GameObject Text;
    public GameObject Wall;
    public AudioSource CrumblingWall;
    public GameObject NormalCross;
    public GameObject InteractCross;

    void Update()
    {
        distanceToObject = PlayerCasting.DistanceFromTarget;
    }

    private void OnMouseOver()
    {
        if (distanceToObject <= distanceRequired)
        {
            NormalCross.SetActive(false);
            InteractCross.SetActive(true);
            ActionDisplay.SetActive(true);
            ActionText.SetActive(true);
			Text.GetComponent<Text>().text = "This wall is strange";
			ActionText.GetComponent<Text>().text = "Push";
        }

        if (Input.GetButtonDown("Action"))
        {
            if (distanceToObject <= distanceRequired)
            {
				this.GetComponent<BoxCollider>().enabled = false;
				ActionDisplay.SetActive(false);
				ActionText.SetActive(false);
				Wall.GetComponent<Animation>().Play("FakeWallAnim");
				CrumblingWall.Play();
				ActionText.GetComponent<Text>().text = "";
            }
        }
    }
    private void OnMouseExit()
    {
		Text.GetComponent<Text>().text = "";
        ActionDisplay.SetActive(false);
        ActionText.SetActive(false);
        InteractCross.SetActive(false);
        NormalCross.SetActive(true);
    }
}
