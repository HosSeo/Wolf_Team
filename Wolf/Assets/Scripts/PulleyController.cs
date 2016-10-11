using UnityEngine;
using System.Collections;

public class PulleyController : MonoBehaviour {

    [SerializeField]
    private float speed;

    [SerializeField]
    private float MaxDistance;

    [SerializeField]
    private GameObject GO_pulley1, GO_pulley2;

    private Pulley S_pulley1;
    private Pulley S_pulley2;
    void Start()
    {
        S_pulley1 = GO_pulley1.GetComponentInChildren<Pulley>();
        S_pulley2 = GO_pulley2.GetComponentInChildren<Pulley>();


        if(false == S_pulley1.Init(speed , MaxDistance))
        {
            Debug.Log("S_pulley1 Init Erorr");
        }
        if(false == S_pulley2.Init(speed , MaxDistance))
        {
            Debug.Log("S_pulley2 Init Erorr");
        }
    }
	
	// Update is called once per frame
	void Update () {

        //if (S_pulley1.GetCollision().CollisionOJ().GetComponent<Rigidbody2D>().mass > S_pulley2.GetCollision().CollisionOJ().GetComponent<Rigidbody2D>().mass)
        //{
        //    S_pulley1.Down();
        //    S_pulley2.Up();
        //}
        //else if (S_pulley1.GetCollision().CollisionOJ().GetComponent<Rigidbody2D>().mass < S_pulley2.GetCollision().CollisionOJ().GetComponent<Rigidbody2D>().mass)
        //{
        //    S_pulley1.Up();
        //    S_pulley2.Down();
        //}
        //else// if (false == S_pulley1.IsCollision() && false == S_pulley2.IsCollision())
        //{
        //    S_pulley1.Standard();
        //    S_pulley2.Standard();
        //}

        if (true == S_pulley2.GetCollision().IsCollision() && true == S_pulley1.GetCollision().IsCollision())
        {
            if (S_pulley1.GetCollision().CollisionOJ().GetComponent<Rigidbody2D>().mass > S_pulley2.GetCollision().CollisionOJ().GetComponent<Rigidbody2D>().mass)
            {
                S_pulley1.Down();
                S_pulley2.Up();
            }

            else if (S_pulley1.GetCollision().CollisionOJ().GetComponent<Rigidbody2D>().mass < S_pulley2.GetCollision().CollisionOJ().GetComponent<Rigidbody2D>().mass)
            {
                S_pulley1.Up();
                S_pulley2.Down();
            }
        }
        else
        {
            if (true == S_pulley1.GetCollision().IsCollision() && false == S_pulley2.GetCollision().IsCollision())
            {
                S_pulley1.Down();
                S_pulley2.Up();
            }
            else if (true == S_pulley2.GetCollision().IsCollision() && false == S_pulley1.GetCollision().IsCollision())
            {
                S_pulley1.Up();
                S_pulley2.Down();
            }
            else// if (false == S_pulley1.IsCollision() && false == S_pulley2.IsCollision())
            {
                S_pulley1.Standard();
                S_pulley2.Standard();
            }
        }
        
    }
}
