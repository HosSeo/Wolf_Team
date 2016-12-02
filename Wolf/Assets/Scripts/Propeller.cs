using UnityEngine;
using System.Collections;

public class Propeller : MonoBehaviour {

    [SerializeField]
    private float speed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.Rotate(Vector3.forward * (speed * Time.deltaTime));
    }
}
