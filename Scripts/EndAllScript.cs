using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndAllScript : MonoBehaviour {

	public void ToLoby()
	{
		SceneManager.LoadScene("lobby");
	}
}
