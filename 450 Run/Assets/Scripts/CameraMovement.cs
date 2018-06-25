using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour 
{
	public Transform playerPos;

	public void Update()
	{
		transform.position = new Vector3 (playerPos.position.x + 6, 0, -10);
	}
}
