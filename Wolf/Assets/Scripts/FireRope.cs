using UnityEngine;
using System.Collections;

public class FireRope : LeverActivity {

    [SerializeField]
    private GameObject unFireRope;
    [SerializeField]
    private float speed;

    [SerializeField]
    private bool isStart = false;
    private bool isEnd = false;
    [SerializeField]
    private FireRope[] nextFireRopes;

    public bool start
    {
        get
        {
            return isStart;
        }
        set
        {
            isStart = value; 
        }
    }

    public bool end
    {
        get
        {
            return isEnd;
        }
        set
        {
            isEnd = value;
        }
    }

    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        if(true == isStart)
        {
            Burn();
        }
        
        if(0 != nextFireRopes.Length && true == isEnd )
        {
            for (int i = 0; i < nextFireRopes.Length; ++i)
                nextFireRopes[i].isStart = true;
        }
	}

    void Burn()
    {
        if (0 < unFireRope.transform.localScale.x)
        {
            unFireRope.transform.localScale = new Vector2(unFireRope.transform.localScale.x - (speed * Time.deltaTime), unFireRope.transform.localScale.y);
            unFireRope.transform.Translate(Vector2.right * ( speed * Time.deltaTime * this.transform.localScale.x ));
        }
        else
        {
            isEnd = true;
            isStart = false;
        }
    }
}
