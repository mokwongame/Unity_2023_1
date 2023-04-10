using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomBallLife : MonoBehaviour
{
    public float startTime = 1.0f;
    public float makeRate = 2.0f;
    public GameObject ball; // gameObject�� ���� �ȵ�
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("makeRandomBall", startTime, makeRate);
    }

    // Update is called once per frame
    void Update()
    {
    }

    void makeRandomBall()
    {
        float xpos = Random.Range(-10.0f, 10.0f); // ����(range)���� �̾Ƽ� ���� �߻�
        float ypos = Random.Range(10.0f, 40.0f);
        float zpos = Random.Range(-10.0f, 10.0f);
        //Vector3 position = new Vector3(xpos, ypos, zpos); // �������� �Ҵ�(= new); new�� �޸� �Ҵ� ������
        Vector3 position;
        position.x = xpos; position.y = ypos; position.z = zpos;
        Instantiate(ball, position, transform.rotation); // �ν��Ͻ�(instance) �����
    }
}
