using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillBall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 오브젝트를 죽이는 함수
        // 10.0f: 10초 뒤에 오브젝트를 파괴
        Destroy(gameObject, 10.0f); // gameObject: 소문자라서 이미 만들어진 오브젝트
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
