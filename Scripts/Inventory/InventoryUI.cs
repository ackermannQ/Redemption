﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    private bool inventoryOpen = false;
	
	public bool InventoryOpen => inventoryOpen;
	public GameObject inventoryParent;
	public GameObject inventoryTab;
	public GameObject craftingTab;
	
	private List<ItemSlot> itemSlotList = new List<ItemSlot>();
	
	public GameObject inventorySlotPrefab;
	public GameObject craftingSlotPrefab;
	
	public Transform inventoryItemTransform;
	
	public Transform craftingItemTransform;
	
	
	public void Start()
	{
		Inventory.instance.onItemChange += UpdateInventoryUI;
		UpdateInventoryUI();
		SetupCraftRecipes();
	}
	
    void Update()
    {
		if (Input.GetKeyDown(KeyCode.I)){
			if (inventoryOpen){
				
				CloseInventory();
			} else {
				
				OpenInventory();
			}
		}
    }
	
	private void SetupCraftRecipes()
	{
		List<Item> craftingRecipes = GameManager.instance.craftingRecipes;
		
		foreach(Item recipe in craftingRecipes)
		{
			GameObject Go = Instantiate(craftingSlotPrefab, craftingItemTransform);
			ItemSlot slot = Go.GetComponent<ItemSlot>();
			slot.AddItem(recipe);
		}
	}
	
	private void UpdateInventoryUI()
	{
		int currentItemCount = Inventory.instance.inventoryItemList.Count;
		if (currentItemCount > itemSlotList.Count)
		{
			AddItemSlots(currentItemCount);
		}
		for (int i = 0; i < itemSlotList.Count; ++i)
		{
			if (i < currentItemCount)
			{
				itemSlotList[i].AddItem(Inventory.instance.inventoryItemList[i]);
			} else {
				itemSlotList[i].DestroySlot();
				itemSlotList.RemoveAt(i);
			}
		}
	}
	
	private void AddItemSlots(int currentItemCount)
	{
		int amount = currentItemCount - itemSlotList.Count;
		
		for (int i = 0; i < amount; ++i)
		{
			GameObject GO = Instantiate(inventorySlotPrefab, inventoryItemTransform);
			ItemSlot newSlot = GO.GetComponent<ItemSlot>();
			itemSlotList.Add(newSlot);
		}
	}
	
	private void OpenInventory(){
		ChangeCursorState(false);
		inventoryOpen = true;
		inventoryParent.SetActive(true);
		OnInventoryTabClicked();
	}
	
	private void CloseInventory(){
		ChangeCursorState(true);
		inventoryOpen = false;
		inventoryParent.SetActive(false);
	}
	
	public void OnCraftingTabClicked(){
		craftingTab.SetActive(true);
		inventoryTab.SetActive(false);
	}
	
	public void OnInventoryTabClicked(){
		craftingTab.SetActive(false);
		inventoryTab.SetActive(true);
	}
	
	private void ChangeCursorState(bool lockCursor){
		if (lockCursor){
			Cursor.lockState = CursorLockMode.Locked;
			Cursor.visible = false;
		} else {
			Cursor.lockState = CursorLockMode.None;
			Cursor.visible = true;
		}
	}

}
