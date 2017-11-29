using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour {
	
	//refer to image comp. Image array
	public Image[] itemImages = new Image[numItemSlots];

	//Item array
	public Item[] items = new Item[numItemSlots];

	//Inventory slots 
	public const int numItemSlots = 4;

	//Add items to inventory (suluis mitä kutsutaan)
	//check te slots to find if item is already in there
	public void AddItem (Item itemToAdd)
	{
		for (int i = 0; i < items.Length; i++) {
			if (items [i] == null) {
				//if item is null then populate it 
				//display prop.
				//turn item image on
				//just for the first one(return)
				items [i] = itemToAdd;
				itemImages [i].sprite = itemToAdd.sprite;
				itemImages [i].enabled = true;
				return;
			}
		}
	}

	public void RemoveItem (Item itemToRemove)
	{
		for (int i = 0; i < items.Length; i++) {
			if (items [i] == itemToRemove ) {
				//if item is in the slot 
				//remove item.
				//dont display it
				items [i] = null;
				itemImages [i].sprite = null;
				itemImages [i].enabled = false;
				return;
			}
		}
	}
}
