using UnityEngine;
using System.Collections;

public class EventObject : MonoBehaviour {

    private Collision collision;
    private bool interSucess = false;
    
    public ParticleSystem sucesseffect; 


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
        if ("Player" != collision.CollisionOJ().tag)
        {
            return;
        }

        if(Input.GetKey(KeyCode.Z))
        {
            interSucess = collision.CollisionOJ().GetComponent<SkillGage>().Increase();
                       
            if (interSucess)           
                sucesseffect.Play();                       
            
        }
    }
}
