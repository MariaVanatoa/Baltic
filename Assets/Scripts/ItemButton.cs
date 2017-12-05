using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ItemButton : MonoBehaviour {

	Button soccerBall;

	// Use this for initialization
	void Start () {
		soccerBall = (Button)GameObject.Find ("SoccerBall").GetComponent<Button> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnPointerClick (PointerEventData eventData)
	{
		Debug.Log ("fsfae");
		Debug.Log (eventData.button);
	}
}
