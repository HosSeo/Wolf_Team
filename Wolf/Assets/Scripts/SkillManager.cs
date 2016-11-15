using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class SkillManager : MonoBehaviour {

    public Skill[] skill;
    public GameObject Player;
    
    private SkillGage skillGage;
    private Skill[] UnClocking;
    private Skill[] Clocking;
    int clockingCount = 0;
    int unClockingCount = 0;

    void Start () {
        skillGage = Player.GetComponent<SkillGage>();
        UnClocking = new Skill[skill.Length];
        Clocking = new Skill[skill.Length];
       
        for (int i = 0; i < skill.Length; ++i)
        {
            if("UnClocking" == skill[i].tag )
            {
                UnClocking[unClockingCount++] = skill[i];
            }
            else if ("Clocking" == skill[i].tag)
            {
                Clocking[clockingCount++] = skill[i];
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift) && 0 < skillGage.GetSkillGage())
        {
            UnClockingOn();
            ClockingOn();
            skillGage.Decrease();
        }
        if (Input.GetKeyUp(KeyCode.LeftShift) || 0 >= skillGage.GetSkillGage())
        {
            UnClockingOFF();
            ClockingOFF();
        }

        ReStart();

    }

    void UnClockingOn()
    {
        for(int i = 0; i < unClockingCount; ++i)
        {
            UnClocking[i].Action();
        }
    }
    void UnClockingOFF()
    {
        for (int i = 0; i < unClockingCount; ++i)
        {
            UnClocking[i].DeAction();
        }
    }

    void ClockingOn()
    {
        for (int i = 0; i < clockingCount; ++i)
        {
            Clocking[i].DeAction();
        }
    }
    void ClockingOFF()
    {
        for (int i = 0; i < clockingCount; ++i)
        {
            Clocking[i].Action();
        }
    }

    void ReStart()
    {
        if (Input.GetKeyUp(KeyCode.P))
        {
            CameraEffect.Instance.EffectOn = true;
        }

        if (true == CameraEffect.Instance.EffectOn)
        {
            if (true == CameraEffect.Instance.FadeOut())
            {
                GameManager.Instance.ReStart();
            }
        }
    }
}
