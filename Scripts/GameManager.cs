using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	bool gameEnd = false;
	public float waitDelay = 2f;

	public GameObject completeLevelUI;
	public GameObject DieLevelUI;

	public void CompleteLevel()
	{
		completeLevelUI.SetActive(true);
		DieLevelUI.SetActive(false);
		Invoke("ContinuedLevel", waitDelay);
	}

	public void EndGame()
	{
		if(gameEnd == false)
		{
			gameEnd = true;
			Invoke("Restart", waitDelay);
		}
	}

	void ContinuedLevel()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}

	void Restart()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
}
