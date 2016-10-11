using UnityEngine;
using System.Collections;

public class SkillManager : MonoBehaviour {

    public Skill[] skill;
    public GameObject Player;

    private SkillGage skillGage;
	void Start () {
        skillGage = Player.GetComponent<SkillGage>();
    }
	
	// Update is called once per frame
	void Update () {

            if (Input.GetKey(KeyCode.LeftShift) && 0 < skillGage.GetSkillGage())
            {
                AshesEyesOn();
                skillGage.Decrease();
            }
        
        if(Input.GetKeyUp(KeyCode.LeftShift) || 0 >= skillGage.GetSkillGage())
        {
            AshesEyesOFF();
        }
    }

    void AshesEyesOn()
    {
        for(int i = 0; i < skill.Length; ++i)
        {
            skill[i].Action();
        }
    }
    void AshesEyesOFF()
    {
        for (int i = 0; i < skill.Length; ++i)
        {
            skill[i].DeAction();
        }
    }
}
