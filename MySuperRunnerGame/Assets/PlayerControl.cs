using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControl : MonoBehaviour
{
    public float speed = 4.0f;
    public float jumpForce = 300.0f;
    Rigidbody2D rb2;
    GameManager gameManager;
    int jumpCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();
        gameManager = FindObjectOfType<GameManager>();
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
        else if (Input.GetKeyUp(KeyCode.Space) && rb2.velocity.y > 0.0f)
        {
            Vector2 vec2 = rb2.velocity;
            vec2.y *= 0.5f; // vec2.y = vec2.y*0.5f
            rb2.velocity = vec2;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            ContactPoint2D pt2 = collision.GetContact(0);
            if (pt2.normal.y > 0.9f)
            {
                gameManager.incScore();
                jumpCount = 0;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Death")
        {
            Invoke("gameOver", 2.0f);
        }
    }

    void gameOver()
    {
        Debug.Log("Game over");
        SceneManager.LoadScene("GameOver");
    }
}
