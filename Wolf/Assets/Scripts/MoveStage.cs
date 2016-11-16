using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

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
        }
    }
}
