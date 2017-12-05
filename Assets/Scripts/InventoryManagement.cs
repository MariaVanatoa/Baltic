using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class InventoryManagement : MonoBehaviour {

	List<GameObject> inventory;
	// Use this for initialization
	void Start () {
		this.inventory = new List<GameObject>();
	}
	
	// Update is called once per frame
	// Mia's Note: Update always listens to what
	// e.g. If the player clicks on an object in the game, it would be detected inside the loop Update:
	// Detection system could be done by adding buttons to the items
	void Update () {
		
	}

	public void OnPointerDown (PointerEventData eventData) {
		Debug.Log (eventData.button);

	}
}
