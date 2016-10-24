using UnityEngine;
using System.Collections;

public class MoveCamera : MonoBehaviour {

    [SerializeField]
    GameObject target;
	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 position = new Vector3(target.transform.position.x, target.transform.position.y , -10.0f);
        this.transform.position = position;
	}
}
