using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Return : MonoBehaviour 
{
	public string levelToLoad;

	public void Update()
	{
		if (Input.GetKeyDown (KeyCode.Escape)) 
		{
			SceneManager.LoadScene (levelToLoad);
		}
	}
}
