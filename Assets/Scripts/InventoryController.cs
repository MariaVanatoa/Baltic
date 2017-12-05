using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryController : MonoBehaviour {

	//private Button changeTextButton;
	private Button showInv;
	private Text lista;
	private Button omena;
	//private Button banaani;
	//private Button kirsikka;
	private Dictionary<Button, GameItem> buttonItemMap = new Dictionary<Button, GameItem>();
	private Player p1 = new Player ();
	//TODO: create player object
	//private Text statusText;


	// Use this for initialization


	void Start () {
		this.lista = GameObject.Find ("Lista").GetComponent<Text> ();
		this.omena = GameObject.Find ("ButtonItem").GetComponent<Button> ();
		//this.banaani = GameObject.Find ("ButtonItem1").GetComponent<Button> ();
		//this.kirsikka = GameObject.Find ("ButtonItem2").GetComponent<Button> ();
		this.showInv = GameObject.Find ("ShowInventory").GetComponent<Button> ();

		buttonItemMap.Add (omena, new GameItem ("omppu"));
		//buttonItemMap.Add (banaani, new GameItem ("banaani"));
		//buttonItemMap.Add (kirsikka, new GameItem ("kirsikka"));

		//banaani.onClick.AddListener (() => ButtonCollectItemClicked(banaani));
		omena.onClick.AddListener (() => ButtonCollectItemClicked(omena));
		//kirsikka.onClick.AddListener (() => ButtonCollectItemClicked(kirsikka));

		//banaani.onClick.AddListener(() => ChangeList ("banaani, "));
		omena.onClick.AddListener (() => ChangeList ("omena, "));
		//kirsikka.onClick.AddListener (() => ChangeList ("kirsikka, "));

		showInv.onClick.AddListener (() => ShowFruits());
		//TODO: add buttonlisteners
		//this.statusText = GameObject.Find ("TextStatus").GetComponent<Text> ();
		//Debug.Log ("textStatus");
		//changeTextButton.onClick.AddListener (() => ButtonClicked("kikkeliskokkelis"));
	}
	/// <summary>
	/// Buttons the collect item clicked.
	/// </summary>
	/// <param name="button">Button.</param>
	void ButtonCollectItemClicked(Button button){
		p1.AddItem (buttonItemMap [button]);
		p1.GetItems ();

		//statusText.text = word;
		//Debug.Log ("Button clicked" + word);
	}
	/// <summary>
	/// Changes the list.
	/// </summary>
	/// <param name="fruit">Fruit.</param>
	void ChangeList(string fruit) {
		this.lista.text = p1.GetItems ();
	}
	/// <summary>
	/// Shows the fruits.
	/// </summary>
	void ShowFruits(){
		p1.ShowInv ();
	}

}