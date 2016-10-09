using UnityEngine;
using System.Collections;

public class AshesEyes : Skill {

    // Use this for initialization
    [SerializeField]
    private GameObject block;

    [SerializeField]
    private float farOfBlack;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	}

    public override void Action()
    {
        this.gameObject.SetActive(true);

        if ("Sinker" == this.gameObject.name)
        {
            Vector2 temp = block.transform.position;
            temp.y += farOfBlack;
            this.gameObject.transform.position = block.transform.position;
            this.gameObject.transform.position = temp;
            block.GetComponentInChildren<Pulley>().SetCollision(true);
        }
    }

    public override void DeAction()
    {
        block.GetComponentInChildren<Pulley>().SetCollision(false);
        this.gameObject.SetActive(false);

    }
}
