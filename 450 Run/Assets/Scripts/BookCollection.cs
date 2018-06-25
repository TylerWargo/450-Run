using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BookCollection : MonoBehaviour 
{
	public AudioSource pickupSound;
	public int score = 0;

	public Text bookCounter;

	public void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Pickup") 
		{
			pickupSound.Play ();
			score++;

			if (score > 0) 
			{
				bookCounter.text = "x" + score.ToString ();
			}
		}
	}
}
