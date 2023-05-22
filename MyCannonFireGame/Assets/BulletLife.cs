using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletLife : MonoBehaviour
{
    public GameObject flame;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 10.0f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //string tag = collision.gameObject.tag;
        if (collision.gameObject.tag == "Player") return;
        else if (collision.gameObject.tag == "Ball") // ����
        {
            Destroy(collision.gameObject, 0.1f); // Ball�� �ı�
        }
        else if (collision.gameObject.tag == "Floor") // ����
        {
        }
        Instantiate(flame, transform.position, transform.rotation);
        Destroy(gameObject, 0.1f); // Bullet�� �ı�
    }
}
