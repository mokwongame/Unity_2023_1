using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollGround : MonoBehaviour
{
    public float speed = 3.0f;
    float width = 6.0f; // 6 ����
    float xmin = -10.0f; // Main Camera Size�� ����
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vec3;
        vec3 = Vector3.left * speed * Time.deltaTime;
        transform.Translate(vec3);
        // ������ ȭ�鿡�� �����
        if (transform.position.x < xmin - width / 2.0f)
        {
            Destroy(gameObject);
        }
    }
}
