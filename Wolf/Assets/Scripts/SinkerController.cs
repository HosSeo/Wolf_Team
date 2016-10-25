using UnityEngine;
using System.Collections;

public class SinkerController : MonoBehaviour {

    [SerializeField]
    private GameObject sinker;
    // Use this for initialization
    Vector2 sinkerPostion;
    Collision pulleyCollision;
	void Start () {
        pulleyCollision = this.gameObject.GetComponent<Pulley>().GetCollision();
    }
	
	// Update is called once per frame
	void Update () {

        if (null != sinker)
        {
            SetPosition();
            DeActionControl();
        }
    }

    void SetPosition()
    {
        sinkerPostion.x = this.transform.position.x;
        sinkerPostion.y = this.transform.position.y + sinker.transform.localScale.y - 0.8f;
        sinker.transform.position = sinkerPostion;
    }

    void DeActionControl()
    {
        if ("Player" == pulleyCollision.CollisionOJ().tag)
        {
            return;
        }
        if (false == sinker.activeSelf)
        {
            
            pulleyCollision.SetCollision(false);
        }
    }
}
