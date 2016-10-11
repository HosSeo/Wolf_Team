using UnityEngine;
using System.Collections;

public class SkillGage : MonoBehaviour {

    // Use this for initialization
    private float skillGage;

    [SerializeField]
    private float value;

    [SerializeField]
    private GameObject gage;
    private Vector3 scale;
   
	void Start () {
        skillGage = 100;
        scale = gage.transform.localScale;

    }
	
	// Update is called once per frame
	void Update () {
        if (0 < scale.x)
        {
            scale.x = skillGage / 100;
            gage.transform.localScale = scale;
        }
    }
    
    public float GetSkillGage()
    {
        return skillGage;
    }

    public void Decrease()
    {
        if (0 < skillGage)
        {
            skillGage -= value;
        }
        Debug.Log(skillGage);
    }

    public void Increase()
    {
        if (100 > skillGage)
        {
            skillGage += value;
        }
    }
}
