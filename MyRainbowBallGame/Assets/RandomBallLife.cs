using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomBallLife : MonoBehaviour
{
    public float startTime = 1.0f;
    public float makeRate = 2.0f;
    public GameObject ball; // gameObject를 쓰면 안됨
    Color[] colors = { Color.red, new Color(1.0f, 0.5f, 0.0f), Color.yellow, Color.green, Color.blue, new Color32(75, 0, 130, 255), new Color32(148, 0, 211, 255) }; // Color 배열
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
        float xpos = Random.Range(-10.0f, 10.0f); // 범위(range)에서 뽑아서 난수 발생
        float ypos = Random.Range(10.0f, 40.0f);
        float zpos = Random.Range(-10.0f, 10.0f);
        int nColor = Random.Range(0, 7); // 0~6(7-1)까지 범위에서 난수 발생
        //Vector3 position = new Vector3(xpos, ypos, zpos); // 생성으로 할당(= new); new는 메모리 할당 연산자
        Vector3 position;
        position.x = xpos; position.y = ypos; position.z = zpos;
        GameObject nowBall = Instantiate(ball, position, transform.rotation); // 인스턴스(instance) 만들기
        // nowBall: ball 설계도로 만든 제품(인스턴스), ball: 생성할 GameObject 설계도
        Renderer rend = nowBall.GetComponent<Renderer>();
        rend.material.color = colors[nColor];
    }
}
