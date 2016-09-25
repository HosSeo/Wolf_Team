using UnityEngine;
using System.Collections;

public class Fire : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if("Rock" == collision.gameObject.tag)
        {
            Debug.Log("dsfsdf");
            Destroy(this.gameObject);
        }
    }
}
