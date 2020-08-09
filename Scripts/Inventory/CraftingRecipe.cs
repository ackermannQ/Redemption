using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
[CreateAssetMenu(fileName = "Item", menuName = "CraftingRecipe/baseRecipe")]

public class CraftingRecipe : Item
{
    public Item result;
	public Ingredient[] ingredients;
	
	public static bool SoulKey = false;
	
	private bool CanCraft()
	{
		// ask the inventory object if there are enough resources
		foreach(Ingredient ingredient in ingredients)
		{
			bool containsCurrentIngredient = Inventory.instance.ContainsItem(ingredient.item, ingredient.amount);
		
			if (!containsCurrentIngredient)
			{
				return false;
			}
		}
		return true;
	}
	
	private void RemoveIngredientsFromInventory()
	{
		foreach(Ingredient ingredient in ingredients)
		{
			Inventory.instance.RemoveItems(ingredient.item, ingredient.amount);
		}
	}
	
	public override void Use()
	{
		if (CanCraft())
		{
			RemoveIngredientsFromInventory();
			
			Inventory.instance.AddItem(result);
			Debug.Log("You just crafted : " + result.name);
			
			if (result.name == "Sou l Key"){
				SoulKey = true;
			}
			
			
		} else {
			Debug.Log("You don't have enough ingredients to craft : " + result.name);
		}
	}
	
	public override string GetItemDescription()
	{
		string itemIngredients = "";
		
		foreach(Ingredient ingredient in ingredients)
		{
			itemIngredients += "- " + ingredient.amount + " " + ingredient.item.name + "\n";
		}
		
		return itemIngredients;
	}
	
	[System.Serializable]
	public class Ingredient
	{
		public Item item;
		public int amount;
		
	}
}
