using UnityEngine.UI;
using UnityEngine;

public class BreakBoxIndication : MonoBehaviour
{
    public float distanceToObject;
    public GameObject ActionText;
    public GameObject Box;
    public GameObject NormalCross;
    public GameObject InteractCross;

    void Update()
    {
        distanceToObject = PlayerCasting.DistanceFromTarget;
    }

    private void OnMouseOver()
    {
        if (distanceToObject <= 8f)
        {
            NormalCross.SetActive(false);
            InteractCross.SetActive(true);
            ActionText.GetComponent<Text>().text = "I could probably destroy this box";
            ActionText.SetActive(true);
        }
    }
    private void OnMouseExit()
    {
        ActionText.SetActive(false);
        InteractCross.SetActive(false);
        NormalCross.SetActive(true);
    }
}
