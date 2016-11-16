using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class SkillManager : MonoBehaviour {

    public Skill[] skill;
    public GameObject Player;
    
    private SkillGage skillGage;
    private Skill[] asheEye;
	void Start () {
        skillGage = Player.GetComponent<SkillGage>();
        asheEye = new Skill[skill.Length];
        for (int i = 0; i < skill.Length; ++i)
        {
            if("AsheEyes" == skill[i].tag )
            {
                asheEye[i] = skill[i];
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
            SceneManager.LoadScene(SceneManager.GetActiveScene().name, LoadSceneMode.Single);
        }

    }

    void AshesEyesOn()
    {
        for(int i = 0; i < asheEye.Length; ++i)
        {
            asheEye[i].Action();
        }
    }
    void AshesEyesOFF()
    {
        for (int i = 0; i < asheEye.Length; ++i)
        {
            asheEye[i].DeAction();
        }
    }
}
