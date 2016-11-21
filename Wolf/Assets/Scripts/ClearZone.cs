using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ClearZone : MonoBehaviour {

    [SerializeField]
    private string stageName;

    private bool effectOn;
    void Update()
    {
        if (false == effectOn)
            return;

        if(true == CameraEffect.Instance.FadeOut())
        {
            SceneManager.LoadScene(stageName, LoadSceneMode.Single);
        }
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if ("Player" == collision.gameObject.tag)
        {
            effectOn = true;
        }
    }
}
