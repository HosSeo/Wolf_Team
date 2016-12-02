using UnityEngine;
using System.Collections;

public class RopeTrigger : MonoBehaviour {

    [SerializeField]
    private FireRope fireRope;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(true == fireRope.end )
        {
            this.GetComponent<Rigidbody2D>().isKinematic = false;
        }
	}
}
