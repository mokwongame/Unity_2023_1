using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float speed = 4.0f;
    public float jumpForce = 300.0f;
    Rigidbody2D rb2;
    int jumpCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // 병진 운동: 좌우
        float xoff = Input.GetAxis("Horizontal")*speed*Time.deltaTime;
        transform.Translate(xoff, 0.0f, 0.0f);
        // 점프
        if (Input.GetKeyDown(KeyCode.Space) && jumpCount < 2)
        {
            jumpCount++;
            // y방향 속도 초기화
            Vector2 vec2 = rb2.velocity;
            vec2.y = 0.0f;
            rb2.velocity = vec2;
            // 점프
            rb2.AddForce(new Vector2(0.0f, jumpForce));
        }
    }
}
