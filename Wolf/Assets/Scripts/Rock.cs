using UnityEngine;
using System.Collections;

public class Rock : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(true == this.GetComponent<Rigidbody2D>().isKinematic)
            this.GetComponent<Rigidbody2D>().isKinematic = false;
    }

    public void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            this.GetComponent<Rigidbody2D>().isKinematic = true;
        }
   
    }
}