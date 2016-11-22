using UnityEngine;

public class Fire : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if ("Rock" == collision.gameObject.tag)
        {
            Destroy(this.gameObject);
        }
    }
}
