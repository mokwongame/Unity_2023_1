using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeBall : MonoBehaviour
{
    public GameObject ball;
    public float startTime = 1.0f;
    public float makeRate = 3.0f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("makeBallObj", startTime, makeRate);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void makeBallObj()
    {
        Instantiate(ball, transform.position, transform.rotation);
    }
}
