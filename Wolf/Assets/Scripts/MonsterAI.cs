using UnityEngine;
using System.Collections;

public class MonsterAI : MonoBehaviour
{

    [SerializeField]
    private float speed;

    private int vector = 1;

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Vector2.right * ((speed * Time.deltaTime) * vector));
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        vector = vector * -1;
    }

    public void OnTriggerExit2D(Collider2D collision)
    {

    }
}
