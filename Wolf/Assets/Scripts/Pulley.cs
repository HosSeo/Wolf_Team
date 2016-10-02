using UnityEngine;
using System.Collections;

public class Pulley : MonoBehaviour
{
    private float speed;
    private float maxDistance;

    private bool isCollision;
    private Vector2 down;
    private Vector2 up;

    private Vector2 standard;
    private float step;

    // Use this for initialization
    private Collider2D collisionOject;
    public GameObject parent;
    void Start()
    {
        standard = this.transform.position;
        collisionOject = null;
    }

    // Update is called once per frame
    void Update()
    {

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

    public Collider2D IsCollision()
    {
        return collisionOject;
    }

    public bool Init(float _speed, float _distance)
    {
        speed = _speed;
        maxDistance = _distance;

        up.x = this.transform.position.x;
        up.y = this.transform.position.y + maxDistance;

        down.x = this.transform.position.x;
        down.y = this.transform.position.y - maxDistance;

        return true;
    }

    public void Up()
    {
        step = speed * Time.deltaTime;
        parent.transform.position = Vector2.MoveTowards(parent.transform.position, up, step);
    }

    public void Down()
    {
        step = speed * Time.deltaTime;
        parent.transform.position = Vector2.MoveTowards(parent.transform.position, down, step);
    }

    public void Standard()
    {
        step = speed * Time.deltaTime;
        parent.transform.position = Vector2.MoveTowards(parent.transform.position, standard, step);
    }
}
