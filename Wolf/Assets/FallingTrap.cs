using UnityEngine;
using System.Collections;

public class FallingTrap : MonoBehaviour {
    // 이동속도
    [SerializeField]
    private float speed;

    private float step;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        step = speed * Time.deltaTime;
        this.transform.Translate(Vector2.down * step);
    }
}
