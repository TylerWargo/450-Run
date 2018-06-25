using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformDestruction : MonoBehaviour 
{
	public void Start()
	{
		Destroy (gameObject, 6f);
	}
}
