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
        // ���ǹ�: if, else if, else
        if (Input.GetKeyDown(KeyCode.Space))
        {
            makeBall();
        }
    }

    void makeBall()
    {
        // ������Ʈ ���� �Լ�
        // transform: empty object�� transform(�ҹ���: �̹� ������ ������Ʈ�� ����)
        Instantiate(ball, transform.position, transform.rotation);
    }
}
