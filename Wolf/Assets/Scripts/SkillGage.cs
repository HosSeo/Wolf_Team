using UnityEngine;
using System.Collections;

public class SkillGage : MonoBehaviour {

    // Use this for initialization
    private float skillGage;
	void Start () {
        skillGage = 100;

    }
	
	// Update is called once per frame
	void Update () {
	
	}
    
    public float GetSkillGage()
    {
        return skillGage;
    }

    public void Decrease()
    {
        if (0 < skillGage)
        {
            skillGage -= 1.0f;
        }
    }

    public void Increase()
    {
        if (100 > skillGage)
        {
            skillGage += 1.0f;
        }
    }
}
