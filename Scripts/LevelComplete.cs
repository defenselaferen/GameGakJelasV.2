using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplate : MonoBehaviour
{
	public void LoadNextLevel()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}
}
