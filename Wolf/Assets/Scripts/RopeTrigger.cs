using UnityEngine;
using System.Collections;

public class RopeTrigger : MonoBehaviour
{

    [SerializeField]
    private FireRope fireRope;

    private bool isActive = false;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (true == fireRope.end && false == isActive )
        {
            this.GetComponent<Rigidbody2D>().isKinematic = false;
            isActive = true;
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if("UnFireRope" == collision.name )
        {
            this.GetComponent<Rigidbody2D>().isKinematic = true;
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if ("UnFireRope" == collision.name)
        {
            this.GetComponent<Rigidbody2D>().isKinematic = false;
        }
    }
}
