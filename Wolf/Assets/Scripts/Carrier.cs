using UnityEngine;
using System.Collections;

public class Carrier : MonoBehaviour {

    // 목적지
    [SerializeField]
    private Vector2 destination;

    // 이동속도
    [SerializeField]
    private float speed;

    private float step;

    // 대각선 움직임 유무
    [SerializeField]
    private bool isDiagonal;

    // 반복 유무
    [SerializeField]
    private bool isRepeat;
    private Vector2 standard;
    
    
    // Use this for initialization
    void Start () {

        // 반복용 기준점 저장
        standard = this.transform.position;

        if (false == isDiagonal)
        {
            if (0 == destination.x)
                destination.x = this.transform.position.x;

            if(0 == destination.y)
                destination.y = this.transform.position.y;
        }
    }
	
	// Update is called once per frame
	void Update () {
        step = speed * Time.deltaTime;
        this.transform.position = Vector2.MoveTowards(this.transform.position, destination, step);

        if((Vector2)this.transform.position == destination)
        {
            destination = standard;
            standard = this.transform.position;
        }
	}
}
