using UnityEngine;
using System.Collections;

public class Collision : MonoBehaviour {

    private Collider2D collisionOject;
    private bool isCollision;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnTriggerEnter2D(Collider2D collision)
    {
        collisionOject = collision;
        isCollision = true;
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        collisionOject = null;
        isCollision = false;
    }

    public void OnTriggerStay2D(Collider2D collision)
    {
        collisionOject = collision;
        isCollision = true;
    }

    public Collider2D CollisionOJ()
    {
        return collisionOject;
    }

    public bool IsCollision()
    {
        return isCollision;
    }

    public void SetCollision(bool _value)
    {
        isCollision = _value;
    }
}
