using UnityEngine;
using System.Collections;

public class Pulley : MonoBehaviour
{
    private float speed;

    private Vector2 down;
    private Vector2 up;

    private Vector2 standard;
    private float step;

    // Use this for initialization
    Collision collision;
    void Start()
    {
        standard = this.transform.position;
        collision = this.gameObject.GetComponentInChildren<Collision>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    public Collision GetCollision()
    {
        return collision;
    }

    public bool Init(float _speed )
    {
        speed = _speed;
        return true;
    }

    public void Up()
    {
        step = speed * Time.deltaTime;
        this.transform.Translate(Vector2.up * step);
    }

    public void Down()
    {
        step = speed * Time.deltaTime;
        this.transform.Translate(Vector2.down * step);
    }

    public void Standard()
    {
        step = speed * Time.deltaTime;
        this.transform.position = Vector2.MoveTowards(this.transform.position, standard, step);
    }
}
