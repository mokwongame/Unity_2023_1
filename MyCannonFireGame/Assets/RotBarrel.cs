using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotBarrel : MonoBehaviour
{
    public float rotSpeed = 100.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float zoff = Input.GetAxis("Vertical") * rotSpeed * Time.deltaTime; // ��� ����
        transform.Rotate(0.0f, 0.0f, zoff); // ȸ��
        Vector3 rotation = transform.rotation.eulerAngles; // ���� ����
        float zang = rotation.z;
        if (zang < 0.0f || zang > 150.0f)
            transform.Rotate(0.0f, 0.0f, -zoff); // ���� ����
    }
}
