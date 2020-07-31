using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	bool gameEnd = false;
	public float waitDelay = 2f;

	public GameObject completeLevelUI;

	public void CompleteLevel()
	{
		completeLevelUI.SetActive(true);
	}

	public void EndGame()
	{
		if(gameEnd == false)
		{
			gameEnd = true;
			Invoke("Restart", waitDelay);
		}
	}

	void Restart()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
}
