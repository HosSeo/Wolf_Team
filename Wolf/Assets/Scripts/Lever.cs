using UnityEngine;
using System.Collections;

public class Lever : MonoBehaviour
{
    [SerializeField]
    private LeverActivity leverActive;
    [SerializeField]
    private Sprite onButtonSprite;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("Stay");
        if("Player" == collision.gameObject.tag )
        {
            Debug.Log("StayPlayer");
            if (Input.GetKeyUp(KeyCode.Z))
            {
                Debug.Log("Z");
                leverActive.enabled = true;
                this.gameObject.GetComponent<SpriteRenderer>().sprite = onButtonSprite;
            }
        }
    }
}
