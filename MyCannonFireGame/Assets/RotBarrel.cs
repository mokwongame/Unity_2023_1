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
        float zoff = Input.GetAxis("Vertical") * rotSpeed * Time.deltaTime; // 상대 각도
        transform.Rotate(0.0f, 0.0f, zoff); // 회전
        Vector3 rotation = transform.rotation.eulerAngles; // 절대 각도
        float zang = rotation.z;
        if (zang < 0.0f || zang > 150.0f)
            transform.Rotate(0.0f, 0.0f, -zoff); // 원상 복구
    }
}
