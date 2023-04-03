using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallLifeWithInput : MonoBehaviour
{
    public GameObject ball;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // 조건문: if, else if, else
        if (Input.GetKeyDown(KeyCode.Space))
        {
            makeBall();
        }
    }

    void makeBall()
    {
        // 오브젝트 생성 함수
        // transform: empty object의 transform(소문자: 이미 생성된 오브젝트에 접근)
        Instantiate(ball, transform.position, transform.rotation);
    }
}
