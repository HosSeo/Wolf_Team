using UnityEngine;
using System.Collections;

public class AshesEyes : Skill {
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (true == this.gameObject.GetComponent<BoxCollider2D>().isTrigger)
            gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
    }

    public override void Action()
    {
        this.gameObject.SetActive(true);
    }

    public override void DeAction()
    {
        this.gameObject.GetComponent<BoxCollider2D>().isTrigger = true;
        this.gameObject.SetActive(false);
    }
}
