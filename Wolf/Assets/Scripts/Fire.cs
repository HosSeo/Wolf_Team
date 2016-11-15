using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

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
        if ("Player" == collision.gameObject.tag)
        {
            SceneManager.LoadScene("tutorial Stage", LoadSceneMode.Single );
        }
    }
}
