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
    private float originalXpos;
   
	void Start () {
        skillGage = 100;
        scale = gage.transform.localScale;
        originalXpos = scale.x;
    }

    // Update is called once per frame
    void Update()
    {
        scale.x = (skillGage / 100) * originalXpos;
        gage.transform.localScale = scale;
    }

    public float GetSkillGage()
    {
        return skillGage;
    }

    public void Decrease()
    {
        if (0 <= skillGage)
        {
            skillGage -= value;
        }
    }

    public bool Increase()
    {
        if (100 > skillGage)
        {
            skillGage  = 100;
            return true;
        }

        return false;
    }
}
