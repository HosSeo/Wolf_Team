using UnityEngine;
using System.Collections;

public class Status : MonoBehaviour {

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
            if(true == CameraEffect.Instance.FadeIn())
            {
                fadeIn = true;
            }
        }
    }

    public void Die()
    {
        GameManager.Instance.ReStart();
    }
}
