using UnityEngine;
using System.Collections;

public class EffectManager {

    private GameObject effect;
    private float delay;
    private float startTime;
    private bool isEnd;
    private static EffectManager instance;

    public static EffectManager Instance
    {
        get
        {
            if(null == instance)
            {
                instance = new EffectManager();
            }
            return instance;
        }    
    }

    public bool Init(GameObject _effect , float _delay)
    {
        if (null != effect)
            return false;

        effect = _effect;
        effect.SetActive(true);
        delay = _delay;
        startTime = Time.time;
        isEnd = false;

        return true;
    }

    private void Clear()
    {
        effect.SetActive(false);
        startTime = Time.time;
        effect = null;
        delay = 0;
        isEnd = true;
    }

    public bool IsEnd()
    {
        return isEnd;
    }

    public void Action()
    {
        if (null == effect)
            return;
        if (delay < Time.time - startTime)
        {
            Clear();
        }
    }
}
