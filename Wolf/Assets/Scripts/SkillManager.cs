using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class SkillManager : MonoBehaviour {

    public Skill[] skill;
    public GameObject Player;
    
    private SkillGage skillGage;
<<<<<<< HEAD
    private Skill[] unClocking;
    private Skill[] Clocking;
    void Start () {
        skillGage = Player.GetComponent<SkillGage>();
        unClocking = new Skill[skill.Length];
        for (int i = 0; i < skill.Length; ++i)
        {
            if("unClocking" == skill[i].tag )
            {
                Debug.Log(skill[i].tag);
                unClocking[i] = skill[i];
=======
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
>>>>>>> Merge
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
<<<<<<< HEAD
            SceneManager.LoadScene("tutorial Stage", LoadSceneMode.Single);
=======
            UnClocking[i].Action();
        }
    }
    void UnClockingOFF()
    {
        for (int i = 0; i < unClockingCount; ++i)
        {
            UnClocking[i].DeAction();
>>>>>>> Merge
        }
    }

    void ClockingOn()
    {
<<<<<<< HEAD
        for(int i = 0; i < unClocking.Length; ++i)
        {
            unClocking[i].Action();
=======
        for (int i = 0; i < clockingCount; ++i)
        {
            Clocking[i].DeAction();
>>>>>>> Merge
        }
    }
    void ClockingOFF()
    {
<<<<<<< HEAD
        for (int i = 0; i < unClocking.Length; ++i)
        {
            unClocking[i].DeAction();
=======
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
>>>>>>> Merge
        }
    }
}
