using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {

	// Make The Variable Global
	public Transform Player;
	public Vector3 offset;
	
	// Update is called once per frame
	void Update ()
	{
		transform.position = Player.position + offset;	
	}
}
