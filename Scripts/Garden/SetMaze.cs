using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class SetMaze : MonoBehaviour
{	
	public GameObject Maze;
	public GameObject key;
	
    private void OnTriggerEnter(Collider col)
    {
		this.GetComponent<BoxCollider>().enabled = false;
		Maze.SetActive(true);
		if (PickUpOldKey.deactivateMaze == false)
		{
			
			key.SetActive(true);
		}
    }
	

}
