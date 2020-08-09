using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
	#region
	public static GameManager instance;

	private void Awake()
	{
		if (instance == null){
			instance = this;
		}
	}
	#endregion
	
    public List<Item> itemList = new List<Item>();
	public List<Item> craftingRecipes = new List<Item>();
	
	public Transform canvas;
	public GameObject itemInfoPrefab;
	private GameObject currentItemInfo = null;
	
	public float moveX = 500;
	public float moveY = 500;
	
	
	private void Update()
	{
		/*if (Input.GetKeyDown(KeyCode.X)){
			Inventory.instance.AddItem(itemList[Random.Range(0, itemList.Count)]);
		}*/
		
		if (PickUpOldKey.GotRustedKey == true){
			Inventory.instance.AddItem(itemList[0]);
			PickUpOldKey.GotRustedKey = false;
		}
		
		if (PickUpLostSoul.GotLostSoul == true){
			Inventory.instance.AddItem(itemList[1]);
			PickUpLostSoul.GotLostSoul = false;
		}
		
	}
	
	public void OnStatItemUse(StatItemType itemType, int amount)
	{
		Debug.Log("Type item : " + itemType + " and amount : "+ amount);
	}
	
	public void DisplayItemInfo(string itemName, string itemDesription, Vector2 buttonPos)
	{
		if (currentItemInfo != null)
		{
			Destroy(currentItemInfo.gameObject);
		}
		buttonPos.x += 500f;
		buttonPos.y -= 500f;
		
		currentItemInfo = Instantiate(itemInfoPrefab, buttonPos, Quaternion.identity, canvas);
		currentItemInfo.GetComponent<ItemInfo>().SetUp(itemName, itemDesription);
	}
	
	public void DestroyItemInfo()
	{
		if (currentItemInfo != null)
		{
			Destroy(currentItemInfo.gameObject);
		}
	}
}
