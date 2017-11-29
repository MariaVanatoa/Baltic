<<<<<<< HEAD
﻿using System;
=======
﻿using System.Collections;
>>>>>>> bb0d65bb48dd24d80f238e33e229bedeb0d67360
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

<<<<<<< HEAD
public class GameItem
{
	private String itemName;
	/// <summary>
	/// Initializes a new instance of the <see cref="GameItem"/> class.
	/// </summary>
	/// <param name="itemName">Item name.</param>
	public GameItem (String itemName)
	{
		this.itemName = itemName;
	}
	/// <summary>
	/// Games the name of the item.
	/// </summary>
	/// <returns>The item name.</returns>
	public String GameItemName() {
		return this.itemName;

	}
}
=======
public class GameItem 
{
	private string itemName;

	public GameItem (string itemName)
		{
			this.itemName = itemName;
		}

	public string GameItemName() {
			return this.itemName;

		}
	}
>>>>>>> bb0d65bb48dd24d80f238e33e229bedeb0d67360
