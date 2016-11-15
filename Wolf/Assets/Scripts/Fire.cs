using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Fire : MonoBehaviour
{ 
    private Collider2D player;
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (false == CameraEffect.Instance.EffectOn )
            return;

        if (true == CameraEffect.Instance.FadeOut())
        {
            player.gameObject.GetComponent<Status>().Die();
            player = null;
        }

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if ("Rock" == collision.gameObject.tag)
        {
            Destroy(this.transform.parent.gameObject);
        }
        if ("Player" == collision.gameObject.tag)
        {
            player = collision;
            CameraEffect.Instance.EffectOn = true;
        }
    }
}
