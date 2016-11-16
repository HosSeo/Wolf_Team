using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ClearZone : MonoBehaviour {

<<<<<<< HEAD
    [SerializeField]
    private string stageName;

=======
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
>>>>>>> parent of 2fa0c82... Clocking , UnClocking 만듬
	void Update () {
	
	}

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if ("Player" == collision.gameObject.tag)
        {
            SceneManager.LoadScene("tutorial Stage", LoadSceneMode.Single);
        }
    }
}
