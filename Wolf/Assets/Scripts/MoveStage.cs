using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class MoveStage : MonoBehaviour {

    public string stageName;
	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if ("Player" == collision.gameObject.tag)
        {
            SceneManager.LoadScene(stageName, LoadSceneMode.Single);
        }
    }
}
