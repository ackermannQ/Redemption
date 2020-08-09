using System.Collections;
using UnityEngine;
using UnityEngine.UI;


public class A0Opening : MonoBehaviour
{
    public GameObject ThePlayer;
    public GameObject FadeScreenIn;
    public GameObject TextBox;

    private void Start()
    {
        StartCoroutine(ScenePlayer());
    
    }

    IEnumerator ScenePlayer()
    {
        yield return new WaitForSeconds(1.5f);
        FadeScreenIn.SetActive(false);
        TextBox.GetComponent<Text>().text = "Where am I ? That voice ...";
        yield return new WaitForSeconds(2.5f);
        TextBox.GetComponent<Text>().text = "";
    }
}
