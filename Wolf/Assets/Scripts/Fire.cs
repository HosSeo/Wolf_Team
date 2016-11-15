using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Fire : MonoBehaviour
<<<<<<< HEAD
{
=======
{ 
    private Collider2D player;
>>>>>>> Merge
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< HEAD
=======
        if (false == CameraEffect.Instance.EffectOn )
            return;

        if (true == CameraEffect.Instance.FadeOut())
        {
            player.gameObject.GetComponent<Status>().Die();
            player = null;
        }
>>>>>>> Merge

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if ("Rock" == collision.gameObject.tag)
        {
            Destroy(this.transform.parent.gameObject);
        }
        if ("Player" == collision.gameObject.tag)
        {
<<<<<<< HEAD
            SceneManager.LoadScene("tutorial Stage", LoadSceneMode.Single );
=======
            player = collision;
            CameraEffect.Instance.EffectOn = true;
>>>>>>> Merge
        }
    }
}
