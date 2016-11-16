﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CameraEffect {

    private static CameraEffect instance;

    private Image fade;
    private float fades = 0f;
    private float time = 0;
    private bool effectOn = false;

    public static CameraEffect Instance
    {
        get
        {
            if (null == instance)
            {
                instance = new CameraEffect();
            }
            return instance;
        }
    }

    public bool EffectOn
    {
        get
        {
            return effectOn;
        }
        set
        {
            effectOn = value;
        }
    }

    public bool FadeOut()
    {
        if (null == fade)
        {
            fade = GameObject.FindWithTag("Fade").GetComponent<Image>();
            fades = 0f;
        }
        time += Time.deltaTime;
        
        if( 1.0f >= fades && time >= 0.1f )
        {
            fades += 0.1f;
            fade.color = new Color(0, 0, 0, fades);
            time = 0;
        }
        else if( 1.0f < fades )
        {
            effectOn = false;
            return true;
        }
        return false;
    }

    public bool FadeIn()
    {
        if (null == fade)
        {
            fade = GameObject.FindWithTag("Fade").GetComponent<Image>();
            fades = 1f;
        }

        time += Time.deltaTime;

        if (0f < fades && time >= 0.1f)
        {
            fades -= 0.1f;
            fade.color = new Color(0, 0, 0, fades);
            time = 0;
        }
        else if (0f >= fades)
        {
            effectOn = false;
            return true;
        }
        return false;
    }
}
