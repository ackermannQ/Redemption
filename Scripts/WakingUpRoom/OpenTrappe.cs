using UnityEngine.UI;
using UnityEngine;

public class OpenTrappe : MonoBehaviour
{
	public static bool isHatchOpen = false;
    public float distanceToObject;
    public float distanceRequired = 4f;

    public GameObject ActionDisplay;
    public GameObject ActionText;
    public GameObject Trappe;
    public AudioSource OpenSound;
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
				ActionDisplay.SetActive(false);
				ActionText.SetActive(false);
				Trappe.GetComponent<Animation>().Play("TrappeAnim");
				OpenSound.Play();
				ActionText.GetComponent<Text>().text = "";
				isHatchOpen = true;
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
