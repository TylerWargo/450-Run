using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookDestruction : MonoBehaviour 
{
	public void OnTriggerEnter2D(Collider2D other)
	{
		Destroy (gameObject);
	}

	public void Start()
	{
		Destroy (gameObject, 6f);
	}
}
