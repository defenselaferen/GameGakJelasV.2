using UnityEngine;
using UnityEngine.UI;

public class Positionning : MonoBehaviour {

	public Transform player;
	public Text positionText;

	void Update ()
	{
		positionText.text = player.position.z.ToString("0");
	}
}
