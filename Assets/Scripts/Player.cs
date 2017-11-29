<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player
{
	private List<GameItem> inventory = new List<GameItem>();

	public Player ()
	{

	}
	//TODO: AddItem method, GetItems method
	/// <summary>
	/// Adds the item.
	/// </summary>
	/// <param name="item">Item.</param>
	public void AddItem(GameItem item) {
		inventory.Add (item);
	}
	/// <summary>
	/// Gets the items.
	/// </summary>
	/// <returns>The items.</returns>
	public String GetItems(){
		string temp = "";
		foreach (GameItem gameIt in inventory) {
			temp += gameIt.GameItemName () + ", ";
		}
		return temp;
	}
	/// <summary>
	/// Shows the inv.
	/// </summary>
	public void ShowInv(){
		string temp = "";
		foreach (GameItem gameIt in inventory) {
			temp += gameIt.GameItemName () + ", ";
		}
		Debug.Log (temp);
	}

}
=======
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
	{
		private List<GameItem> inventory = new List<GameItem>();

	public  Player ()
		{

		}
		//TODO: AddItem method, GetItems method
		public void AddItem(GameItem item) {
			inventory.Add (item);
		}

	public string GetItems(){
			string temp = "";
			foreach (GameItem gi in inventory) {
				temp += gi.GameItemName () + ", ";
			}
			return temp;
		}
		public void ShowInv(){
			string temp = "";
			foreach (GameItem gi in inventory) {
				temp += gi.GameItemName () + ", ";
			}
			Debug.Log (temp);
		}

	}
>>>>>>> bb0d65bb48dd24d80f238e33e229bedeb0d67360
