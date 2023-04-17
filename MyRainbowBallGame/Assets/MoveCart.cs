using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCart : MonoBehaviour
{
    public float speed = 20.0f;
    int nColor = 0; // 카트 색깔; 색깔 배열은 RandomBallLife.colors에 있음
    GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        // 외부에 있는 오브젝트의 인스턴스 찾기
        gameManager = FindObjectOfType<GameManager>();
        // Renderer 찾기
        Renderer rend = gameObject.GetComponent<Renderer>();
        rend.material.color = RandomBallLife.colors[nColor];
    }

    // Update is called once per frame
    void Update()
    {
        // 카트 색깔 변경
        if (Input.GetKeyDown(KeyCode.Space))
        {
            nColor++; // 색깔 배열에 접근할 위치(0~6)
            //nColor = nColor % 7;
            nColor = nColor % RandomBallLife.colors.Length; // 7 대신 배열 개수로 나머지 연산
            Renderer rend = gameObject.GetComponent<Renderer>();
            rend.material.color = RandomBallLife.colors[nColor];
        }
        // 카트 이동
        float xoff = Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime; // 수평 이동
        float zoff = Input.GetAxisRaw("Vertical") * speed * Time.deltaTime; // 수직(3D에서는 z방향) 이동;
        gameObject.transform.Translate(xoff, 0.0f, zoff);
    }

    // 충돌(collision) 이벤트 처리기
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            Renderer ballRend = collision.gameObject.GetComponent<Renderer>();
            Color ballColor = ballRend.material.color;
            // 공 색깔 == 카트 색깔이면 득점, 아니면 감점
            if (ballColor == RandomBallLife.colors[nColor])
                gameManager.incScore(); // score = score + 1
            else gameManager.decScore();   // score = score - 1
            Debug.Log("score = " + gameManager.getScore()); // 콘솔에서 로그 보기
            Destroy(collision.gameObject, 0.1f); // 충돌한 ball을 0.1초 후에 파괴
        }
    }
}
