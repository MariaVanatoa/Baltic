using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionObjects : MonoBehaviour {
	//On and off behavors
	public bool inventory; //if true this object can be stored in inventory
	public bool openable;  //if true object can be opened
	public bool locked;    //if this is true then object is locked
	public bool talks;   //if this is true then object can talk to player
	public string itemType;  //this will tell what type of item this object is

	public GameObject itemNeeded;  //item needed in order to interact with this item
	public string message;   //the message this object will give player 

	public Animator anim;

	//turns game object of when interacted
	public void DoInteraction()
	{
		//Picked up and put in inventory
		gameObject.SetActive(false);
	}

	//open door animator
	public void Open()
	{
		anim.SetBool ("open", true);
	}

	public void Talk()
	{
		Debug.Log (message);
	}
}
