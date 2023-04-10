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
        float xoff = Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime; // ���� �̵�
        float zoff = Input.GetAxisRaw("Vertical") * speed * Time.deltaTime; // ����(3D������ z����) �̵�;
        gameObject.transform.Translate(xoff, 0.0f, zoff);
    }

    // �浹(collision) �̺�Ʈ ó����
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            score++; // score = score + 1
            Debug.Log("score = " + score); // �ֿܼ��� �α� ����
            Destroy(collision.gameObject, 0.1f); // �浹�� ball�� 0.1�� �Ŀ� �ı�
        }
    }
}
