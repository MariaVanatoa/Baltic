using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour {

	public float speed;

	public Animator anim;
	public float health;

	public Text healthText;

	// Use this for initialization
	void Start () {
		//changing the the in the box
		healthText.text = "Health: " + health.ToString ();
	}
	
	// Update is called once per frame
	void Update () {

		float horizontal = Input.GetAxisRaw ("Horizontal");
		float vertical = Input.GetAxisRaw ("Vertical");

		//moving right
		if (horizontal > .01f) {
			transform.rotation = Quaternion.Euler (0f, 0f, 90f);
		}
		//moving left
		if (horizontal < -.01f) {
			transform.rotation = Quaternion.Euler (0f, 0f, 270f);
		}
		//moving up
		if (vertical > .01) {
			transform.rotation = Quaternion.Euler (0f, 0f, 180f);
		}
		//moving down
		if (vertical > -.01) {
			transform.rotation = Quaternion.Euler (0f, 0f, 0f);
		}

		//moving
		transform.Translate (horizontal * speed * Time.deltaTime, vertical * speed * Time.deltaTime, 0f, Space.World);

		//tell the ainimator witch animation to play
		anim.SetFloat("speed", Mathf.Abs (horizontal) + Mathf.Abs(vertical));
	}

	public void TakeDamage(int damage)
	{
		health -= damage;
		if (health <= 0) {
			Debug.Log ("Dead");
			health = 0;
		}
		healthText.text = "Health: " + health.ToString ();
	}
}
