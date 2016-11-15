using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
<<<<<<< HEAD
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
=======

public class MoveStage : MonoBehaviour
{
    [SerializeField]
    private string stageName;

    // Update is called once per frame
    void Update()
    {
        if (false == CameraEffect.Instance.EffectOn)
            return;

        if (true == CameraEffect.Instance.FadeOut())
        {
            GameManager.Instance.MoveStage(stageName);
        }
    }

    public void OnTriggerStay2D(Collider2D collision)
    {
        if ("Player" == collision.gameObject.tag)
        {
            if (Input.GetKeyUp(KeyCode.Z))
            {
                CameraEffect.Instance.EffectOn = true;
            }
>>>>>>> Merge
        }
    }
}
