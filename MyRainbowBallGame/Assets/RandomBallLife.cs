using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomBallLife : MonoBehaviour
{
    public float startTime = 1.0f;
    public float makeRate = 2.0f;
    public GameObject ball; // gameObject�� ���� �ȵ�
    Color[] colors = { Color.red, new Color(1.0f, 0.5f, 0.0f), Color.yellow, Color.green, Color.blue, new Color32(75, 0, 130, 255), new Color32(148, 0, 211, 255) }; // Color �迭
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
        int nColor = Random.Range(0, 7); // 0~6(7-1)���� �������� ���� �߻�
        //Vector3 position = new Vector3(xpos, ypos, zpos); // �������� �Ҵ�(= new); new�� �޸� �Ҵ� ������
        Vector3 position;
        position.x = xpos; position.y = ypos; position.z = zpos;
        GameObject nowBall = Instantiate(ball, position, transform.rotation); // �ν��Ͻ�(instance) �����
        // nowBall: ball ���赵�� ���� ��ǰ(�ν��Ͻ�), ball: ������ GameObject ���赵
        Renderer rend = nowBall.GetComponent<Renderer>();
        rend.material.color = colors[nColor];
    }
}
