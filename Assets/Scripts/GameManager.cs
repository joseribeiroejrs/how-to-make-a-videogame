using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	bool gameHasEnded = false;
	public float restartDelay = 2f;
	public GameObject completeLevelUI;

	public void CompleteLevel ()
	{
		Debug.Log("Level won!");
		completeLevelUI.SetActive(true);
	}
	public void EndGame()
	{
		if (!gameHasEnded)
		{
			gameHasEnded = true;
			Debug.Log("End game!");
			Invoke("Restart", restartDelay);
		}
	}

	void Restart ()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		gameHasEnded = false;
	}
}
