using UnityEngine;
using System.Collections;

public class LightControl : MonoBehaviour {

    [SerializeField]
    private float speed;
    [SerializeField]
    private float max;
    [SerializeField]
    private float min;

    private float vector = 1;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (max <= this.GetComponent<Light>().intensity)
            vector *= -1;

        if (min >= this.GetComponent<Light>().intensity)
            vector *= -1;

        this.GetComponent<Light>().intensity = this.GetComponent<Light>().intensity + (speed * vector);
    }
}
