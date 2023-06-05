using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollBack : MonoBehaviour
{
    public float speed = 1.0f;
    float width = 20.0f; // 20 유닛
    float xmin = -10.0f; // Main Camera Size에 연동
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vec3;
        vec3 = Vector3.left*speed*Time.deltaTime;
        transform.Translate(vec3);
        // 배경이 화면에서 사라짐
        if (transform.position.x < xmin - width/2.0f)
        {
            transform.Translate(2.0f*width, 0.0f, 0.0f);
        }
    }
}
