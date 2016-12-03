using UnityEngine;
using System.Collections;

public class Status : MonoBehaviour
{

    private bool fadeIn;

    void Start()
    {
        fadeIn = false;
    }
    // Update is called once per frame
    void Update()
    {
        if (false == fadeIn)
        {
            if (true == CameraEffect.Instance.FadeIn())
            {
                fadeIn = true;
            }
        }

        if( true == CameraEffect.Instance.EffectOn )
        {
            if(true == CameraEffect.Instance.FadeOut())
            {
                Die();
            }
        }
    }

    public void Die()
    {
        GameManager.Instance.ReStart();
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if("Danger" == collision.tag)
        {
            CameraEffect.Instance.EffectOn = true;
        }

        if ("Danger_Clocking" == collision.tag)
        {
            CameraEffect.Instance.EffectOn = true;
        }

        if ("Clocking" == collision.tag || "UnClocking" == collision.tag)
        {
            CameraEffect.Instance.EffectOn = true;
        }
    }
}
