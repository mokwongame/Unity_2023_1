using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallWithInput : MonoBehaviour
{
    public bool isKinematic = true;
    public float speed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody rb = gameObject.GetComponent<Rigidbody>();
        rb.isKinematic = isKinematic;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Rigidbody rb = gameObject.GetComponent<Rigidbody>();
            isKinematic = !isKinematic;
            rb.isKinematic = isKinematic; // !: not(�� ����)
        }
        // ���� �̵�
        float xoff = Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime; // Input.GetAxisRaw("Horizontal"): ���� ����(�¿�) �Է� ���; -1, 1, 0
        float zoff = Input.GetAxisRaw("Vertical") * speed * Time.deltaTime; // Input.GetAxisRaw("Horizontal"): ���� ����(����) �Է� ���; -1, 1, 0
        gameObject.transform.Translate(xoff, 0.0f, zoff); // ��ü�� ���� �(��ü �߽��� �����̴� �
    }
}
