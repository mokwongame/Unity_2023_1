using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallWithInput : MonoBehaviour
{
    public bool isKinematic = true;
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
    }
}
