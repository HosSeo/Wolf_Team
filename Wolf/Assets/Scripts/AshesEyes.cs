using UnityEngine;
using System.Collections;

public class AshesEyes : Skill {
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	}

    public override void Action()
    {
        this.gameObject.SetActive(true);
    }

    public override void DeAction()
    {
        this.gameObject.SetActive(false);
    }
}
