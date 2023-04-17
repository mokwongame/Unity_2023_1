using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCart : MonoBehaviour
{
    public float speed = 20.0f;
    public int score = 0;
    int nColor = 0; // īƮ ����; ���� �迭�� RandomBallLife.colors�� ����
    // Start is called before the first frame update
    void Start()
    {
        Renderer rend = gameObject.GetComponent<Renderer>();
        rend.material.color = RandomBallLife.colors[nColor];
    }

    // Update is called once per frame
    void Update()
    {
        // īƮ ���� ����
        if (Input.GetKeyDown(KeyCode.Space))
        {
            nColor++; // ���� �迭�� ������ ��ġ(0~6)
            //nColor = nColor % 7;
            nColor = nColor % RandomBallLife.colors.Length; // 7 ��� �迭 ������ ������ ����
            Renderer rend = gameObject.GetComponent<Renderer>();
            rend.material.color = RandomBallLife.colors[nColor];
        }
        // īƮ �̵�
        float xoff = Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime; // ���� �̵�
        float zoff = Input.GetAxisRaw("Vertical") * speed * Time.deltaTime; // ����(3D������ z����) �̵�;
        gameObject.transform.Translate(xoff, 0.0f, zoff);
    }

    // �浹(collision) �̺�Ʈ ó����
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            Renderer ballRend = collision.gameObject.GetComponent<Renderer>();
            Color ballColor = ballRend.material.color;
            // �� ���� == īƮ �����̸� ����, �ƴϸ� ����
            if (ballColor == RandomBallLife.colors[nColor])
                score++; // score = score + 1
            else score--;   // score = score - 1
            Debug.Log("score = " + score); // �ֿܼ��� �α� ����
            Destroy(collision.gameObject, 0.1f); // �浹�� ball�� 0.1�� �Ŀ� �ı�
        }
    }
}