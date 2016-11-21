using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
public class SkillManager : MonoBehaviour {
    public GameObject Player;
    
    private SkillGage skillGage;

    private GameObject[] unClocking;
    private GameObject[] clocking;

    void Start () {

        skillGage = Player.GetComponent<SkillGage>();
        unClocking = GameObject.FindGameObjectsWithTag("UnClocking");
        clocking = GameObject.FindGameObjectsWithTag("Clocking");

        for (int i = 0; i < unClocking.Length; ++i)
        {
            unClocking[i].GetComponent<Skill>().DeAction();
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
            ClockingOFF();
            UnClockingOFF();
        }

        if (Input.GetKeyUp(KeyCode.P))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name, LoadSceneMode.Single);
        }

    }

    void UnClockingOn()
    {
        for(int i = 0; i < unClocking.Length; ++i)
        {
            unClocking[i].GetComponent<Skill>().Action();
        }
    }

    void UnClockingOFF()
    {
        for (int i = 0; i < unClocking.Length; ++i)
        {
            unClocking[i].GetComponent<Skill>().DeAction();
        }
    }

    void ClockingOn()
    {
        for (int i = 0; i < clocking.Length; ++i)
        {
            clocking[i].GetComponent<Skill>().DeAction();
        }
    }
    void ClockingOFF()
    {
        for (int i = 0; i < clocking.Length; ++i)
        {
            clocking[i].GetComponent<Skill>().Action();
        }
    }
}
