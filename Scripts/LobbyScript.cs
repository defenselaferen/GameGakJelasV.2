using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LobbyScript : MonoBehaviour {

	public void Play()
	{
		SceneManager.LoadScene("Level1");
	}
	public void Quit()
	{
		Application.Quit();
	}
	public void LevelOption()
	{
		SceneManager.LoadScene("LevelOptions");
	}
}
