using UnityEngine;
using System.Collections;

public class EventObject : MonoBehaviour {

    private Collision collision;
	// Use this for initialization
	void Start () {
        collision = this.GetComponentInChildren<Collision>();

    }
	
	// Update is called once per frame
	void Update () {
        Interaction();

    }

    void Interaction()
    {
        if("Player" != collision.CollisionOJ().tag)
        {
            return;
        }

        if (Input.GetKey(KeyCode.Z))
        {
            collision.CollisionOJ().GetComponent<SkillGage>().Increase();
        }

    }
}
