using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeath : MonoBehaviour 
{
	public GameObject playerGO;
	public float fallDeathLevel = -50f;
	private bool playerDead = false;

	public void Update()
	{
		if (playerGO.transform.position.y <= fallDeathLevel) 
		{
			Destroy (playerGO);
			playerDead = true;
		}

		if (playerDead == true) 
		{
			SceneManager.LoadScene ("Title");
		}
	}
}