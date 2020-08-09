using UnityEngine.UI;
using UnityEngine;

public class lockedSafe : MonoBehaviour
{
    public float distanceToObject;
    public float distanceRequired = 5f;

    public GameObject ActionDisplay;
    public GameObject ActionText;
    public GameObject Safe;
    public AudioSource UnlockSound;
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
			ActionText.GetComponent<Text>().text = "Open";
        }

        if (Input.GetButtonDown("Action"))
        {
            if (distanceToObject <= distanceRequired)
            {

				this.GetComponent<BoxCollider>().enabled = false;
				ActionDisplay.SetActive(false);
				ActionText.SetActive(false);
				Safe.GetComponent<Animation>().Play("SafeOpenAnim");
				UnlockSound.Play();
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
