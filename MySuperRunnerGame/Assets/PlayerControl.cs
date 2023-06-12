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
        // ���� �: �¿�
        float xoff = Input.GetAxis("Horizontal")*speed*Time.deltaTime;
        transform.Translate(xoff, 0.0f, 0.0f);
        // ����
        if (Input.GetKeyDown(KeyCode.Space) && jumpCount < 2)
        {
            jumpCount++;
            // y���� �ӵ� �ʱ�ȭ
            Vector2 vec2 = rb2.velocity;
            vec2.y = 0.0f;
            rb2.velocity = vec2;
            // ����
            rb2.AddForce(new Vector2(0.0f, jumpForce));
        }
    }
}
