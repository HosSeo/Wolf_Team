using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class SkillManager : MonoBehaviour {

    public Skill[] skill;
    public GameObject Player;
    
    private SkillGage skillGage;
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
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift) && 0 < skillGage.GetSkillGage())
        {
            AshesEyesOn();
            skillGage.Decrease();
        }
        if (Input.GetKeyUp(KeyCode.LeftShift) || 0 >= skillGage.GetSkillGage())
        {
            AshesEyesOFF();
        }


        if (Input.GetKeyUp(KeyCode.P))
        {
            SceneManager.LoadScene("tutorial Stage", LoadSceneMode.Single);
        }

    }

    void AshesEyesOn()
    {
        for(int i = 0; i < unClocking.Length; ++i)
        {
            unClocking[i].Action();
        }
    }
    void AshesEyesOFF()
    {
        for (int i = 0; i < unClocking.Length; ++i)
        {
            unClocking[i].DeAction();
        }
    }
}
