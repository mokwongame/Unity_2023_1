using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillBall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // ������Ʈ�� ���̴� �Լ�
        // 10.0f: 10�� �ڿ� ������Ʈ�� �ı�
        Destroy(gameObject, 10.0f); // gameObject: �ҹ��ڶ� �̹� ������� ������Ʈ
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
