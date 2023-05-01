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
            rb.isKinematic = isKinematic; // !: not(논리 부정)
        }
        // 공을 이동
        float xoff = Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime; // Input.GetAxisRaw("Horizontal"): 수평 방향(좌우) 입력 얻기; -1, 1, 0
        float zoff = Input.GetAxisRaw("Vertical") * speed * Time.deltaTime; // Input.GetAxisRaw("Horizontal"): 수직 방향(상하) 입력 얻기; -1, 1, 0
        gameObject.transform.Translate(xoff, 0.0f, zoff); // 물체의 병진 운동(물체 중심이 움직이는 운동
    }
}
