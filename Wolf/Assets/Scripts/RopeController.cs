using UnityEngine;
using System.Collections;

public class RopeController : MonoBehaviour {

    // Use this for initialization
    [SerializeField]
    private LineRenderer rope;
    
    [SerializeField]
    private float pulleyToRope;
    [SerializeField]
    private float positionControl;
    [SerializeField]
    private float ceilingHight;

    

	void Start () {
        Vector2 ceilingPosition;
        ceilingPosition.x = this.transform.position.x + this.transform.localScale.x + positionControl;
        ceilingPosition.y = ceilingHight;

        rope.SetPosition(0, ceilingPosition );
    }
	
	// Update is called once per frame
	void Update () {
        ropeControl();

    }

    void ropeControl()
    {
        Vector2 ropePosition;
        ropePosition.x = this.transform.position.x + this.transform.localScale.x + positionControl;
        ropePosition.y = this.transform.position.y + pulleyToRope;

        rope.SetPosition(1, ropePosition);
    }
}
