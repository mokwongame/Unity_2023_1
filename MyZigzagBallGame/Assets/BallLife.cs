using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// class: ������Ʈ�� ���赵
public class BallLife : MonoBehaviour
{
    public GameObject ball; // Unity Editor���� �ʱ�ȭ(�빮��: class�� ����)
    // Start is called before the first frame update
    void Start() // ���� �ѹ��� ����
    {
        // �ݺ��ؼ� ù��° ���ڰ� ǥ���ϴ� �Լ��� ����
        // makeBall: ������ �Լ���
        // 1.0f: ���� �ð�(1�� �ڿ� ����)
        // 4.0f: �ݺ� �ð�(4�ʿ� �ѹ��� ����)
        InvokeRepeating("makeBall", 1.0f, 4.0f); // 1, 5, 9, 13, 17, ...
    }

    // Update is called once per frame
    void Update() // �ݺ��ؼ� ����
    {
        
    }

    void makeBall()
    {
        // ������Ʈ ���� �Լ�
        // transform: empty object�� transform(�ҹ���: �̹� ������ ������Ʈ�� ����)
        Instantiate(ball, transform.position, transform.rotation);
    }
}
