using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ACreepyDoorTrigger : MonoBehaviour
{
    public AudioSource DoorBang;
    public GameObject Door;
	
	public GameObject ExperimentRoomHuman;
	public GameObject ExperimentRoomDemon;
	
	public Animation fadeScreenAnim;


    private void OnTriggerEnter()
    {
        GetComponent<BoxCollider>().enabled = false;
        Door.GetComponent<Animation>().Play("CreepyDoor1");
        DoorBang.Play();
		ExperimentRoomHuman.SetActive(true);
		fadeScreenAnim.Play();
		ExperimentRoomDemon.SetActive(false);
    }

}
