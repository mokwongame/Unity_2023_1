using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCannon : MonoBehaviour
{
    public float speed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float xoff = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        transform.Translate(xoff, 0.0f, 0.0f);
    }
}
