using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCart : MonoBehaviour
{
    public float speed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float xoff = Input.GetAxis("Horizontal") * speed * Time.deltaTime; // 수평 방향
        float zoff = Input.GetAxis("Vertical") * speed * Time.deltaTime; // 수직 방향
        //gameObject.transform.Translate(xoff, 0.0f, zoff);
        //transform.Translate(xoff, 0.0f, zoff);
        Vector3 vecOff = xoff * transform.right - zoff * transform.forward;
        transform.Translate(vecOff);
    }
}
