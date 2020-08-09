using UnityEngine;
using UnityEngine.UI;

public class GlobalAmmo : MonoBehaviour
{
	public static int AmmoCount;
	public int internalAmmo = 0;
	
	public GameObject AmmoDisplay;
	
    void Update(){
		internalAmmo = AmmoCount;
		AmmoDisplay.GetComponent<Text>().text = "" + AmmoCount;
	}
}
