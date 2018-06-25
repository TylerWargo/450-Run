using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGen : MonoBehaviour 
{
	public Transform playerTrans;
	public Transform platformHalfTrans;

	public Transform platformSpawn3;
	public Transform platformSpawn2;
	public Transform platformSpawn1;

	public GameObject platformPrefab;
	public GameObject bookPrefab;

	private int psID;
	private int psIDMin = 1;
	private int psIDMax = 4;

	private bool canSpawn = true;

	public void Start()
	{
		platformSpawn3 = GameObject.Find ("Spawning Point 3").transform;
		platformSpawn2 = GameObject.Find ("Spawning Point 2").transform;
		platformSpawn1 = GameObject.Find ("Spawning Point 1").transform;

		playerTrans = GameObject.Find ("Player").transform;

		platformHalfTrans = this.gameObject.transform.GetChild (0);

		Destroy (gameObject, 6f);
	}

	public void Update()
	{
		if (playerTrans.position.x >= platformHalfTrans.position.x && canSpawn == true) 
		{
			canSpawn = false;
			psID = Random.Range (psIDMin, psIDMax);

			switch (psID) 
			{
			case 3:
				Debug.Log ("Spawn at 3");
				Instantiate (platformPrefab, platformSpawn3.position, transform.rotation);
				break;
			case 2:
				Debug.Log ("Spawn at 2");
				Instantiate (platformPrefab, platformSpawn2.position, transform.rotation);
				break;
			case 1:
				Instantiate (platformPrefab, platformSpawn1.position, transform.rotation);
				Debug.Log ("Spawn at 1");
				break;
			default:
				Instantiate (platformPrefab, platformSpawn1.position, transform.rotation);
				Debug.Log ("Spawn at Default, 1");
				break;
			}
		}
	}
}
