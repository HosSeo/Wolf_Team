using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MoveStage : MonoBehaviour {

    [SerializeField]
    private string stageName;

    private bool effectOn;
    void Update()
    {
        if (false == effectOn)
            return;

        if (true == CameraEffect.Instance.FadeOut())
        {
            SceneManager.LoadScene(stageName, LoadSceneMode.Single);
        }
    }
    public void OnTriggerStay2D(Collider2D collision)
    {
        if ("Player" == collision.gameObject.tag)
        {
            if(Input.GetKeyUp(KeyCode.Z))
                effectOn = true;
        }
    }
}
