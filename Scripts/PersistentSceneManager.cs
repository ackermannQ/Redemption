using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PersistentSceneManager : MonoBehaviour
{
	public static PersistentSceneManager instance;
	
	public GameObject loadingScreen;
	
	private void Awake()
	{
		instance = this;
		
	}
	
	public void LoadGame()
	{
		SceneManager.LoadSceneAsync((int)SceneIndexes.TITLE_SCREEN, LoadSceneMode.Additive);
		//loadingScreen.gameObject.SetActive(true);
		SceneManager.UnloadSceneAsync((int)SceneIndexes.TITLE_SCREEN);
		SceneManager.LoadSceneAsync((int)SceneIndexes.MAP, LoadSceneMode.Additive);
	}
}
