using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameManager {

    private static GameManager instance;

    private GameManager() {
	}

    public static GameManager Instance
    {
        get
        {
            if (null == instance)
            {
                instance = new GameManager();
            }
            return instance;
        }
    }

    public void ReStart()
    {
         SceneManager.LoadScene(SceneManager.GetActiveScene().name, LoadSceneMode.Single);
    }
}
