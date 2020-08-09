using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BZbisJumpTrigger : MonoBehaviour
{
    public AudioSource DoorBang;
    public GameObject Door;


    private void OnTriggerEnter()
    {
        GetComponent<BoxCollider>().enabled = false;
        Door.GetComponent<Animation>().Play("JumpDoorAnim");
        DoorBang.Play();
    }
}
