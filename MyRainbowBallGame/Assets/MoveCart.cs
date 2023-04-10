using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCart : MonoBehaviour
{
    public float speed = 20.0f;
    public int score = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float xoff = Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime; // 수평 이동
        float zoff = Input.GetAxisRaw("Vertical") * speed * Time.deltaTime; // 수직(3D에서는 z방향) 이동;
        gameObject.transform.Translate(xoff, 0.0f, zoff);
    }

    // 충돌(collision) 이벤트 처리기
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            score++; // score = score + 1
            Debug.Log("score = " + score); // 콘솔에서 로그 보기
            Destroy(collision.gameObject, 0.1f); // 충돌한 ball을 0.1초 후에 파괴
        }
    }
}
