using UnityEngine;
using System.Collections;

public class NPC_UI : MonoBehaviour {

    [SerializeField]
    GameObject image;
    [SerializeField]
    int Stage;
    [SerializeField]
    Collision collision;

    
    // Use this for initialization
    void Start () {
        image.SetActive(false);

    }
	
	// Update is called once per frame
	void Update () {
        if ("Player" != collision.CollisionOJ().tag)
        {
            return;
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            if(true == image.activeSelf )
            {
                image.SetActive(false);
                return;
            }
            image.SetActive(true);
        }
    }
}
