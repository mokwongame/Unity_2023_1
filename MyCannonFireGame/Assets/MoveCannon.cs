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
        float xoff = Input.GetAxis("Horizontal") * speed * Time.deltaTime; // 상대 위치
        transform.Translate(xoff, 0.0f, 0.0f);
        Vector3 position = transform.position; // 절대 위치
        float xpos = position.x; // xpos를 제한
        xpos = Mathf.Clamp(xpos, -8.0f, 8.0f);
        //if (xpos <= -8.0f) xpos = -8.0f;
        //else if (xpos >= 8.0f) xpos = 8.0f;
        position.x = xpos;
        transform.position = position;
        //Debug.Log(xoff);
    }
}
