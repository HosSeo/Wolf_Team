﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ClearZone : MonoBehaviour {

    [SerializeField]
    private string stageName;

	void Update () {

        if (false == CameraEffect.Instance.EffectOn)
            return;

        if (true == CameraEffect.Instance.FadeOut())
        {
            GameManager.Instance.MoveStage(stageName);
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if ("Player" == collision.gameObject.tag)
        {
            CameraEffect.Instance.EffectOn = true;
        }
    }
}
