using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// class: 오브젝트의 설계도
public class BallLife : MonoBehaviour
{
    public GameObject ball; // Unity Editor에서 초기화(대문자: class에 접근)
    // Start is called before the first frame update
    void Start() // 최초 한번만 실행
    {
        // 반복해서 첫번째 인자가 표현하는 함수를 실행
        // makeBall: 실행할 함수명
        // 1.0f: 시작 시간(1초 뒤에 시작)
        // 4.0f: 반복 시간(4초에 한번씩 실행)
        InvokeRepeating("makeBall", 1.0f, 4.0f); // 1, 5, 9, 13, 17, ...
    }

    // Update is called once per frame
    void Update() // 반복해서 실행
    {
        
    }

    void makeBall()
    {
        // 오브젝트 생성 함수
        // transform: empty object의 transform(소문자: 이미 생성된 오브젝트에 접근)
        Instantiate(ball, transform.position, transform.rotation);
    }
}
