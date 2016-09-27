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

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if ("Rock" == collision.gameObject.tag)
        {
            Destroy(this.transform.parent.gameObject);

        }
    }
}
