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
<<<<<<< HEAD

    public void MoveStage(string _stageName)
    {
        SceneManager.LoadScene(_stageName, LoadSceneMode.Single);
    }
=======
>>>>>>> parent of 2fa0c82... Clocking , UnClocking 만듬
}
