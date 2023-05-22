using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotBarrel : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip clipGunFire;
    public GameObject bullet;
    public GameObject smoke;
    public float rotSpeed = 100.0f;
    public float power = 500;
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
        if (Input.GetKeyDown(KeyCode.Space))
            fireBullet();
    }

    void fireBullet()
    {
        Vector3 position = transform.position + transform.right * 2.0f + transform.up * 0.4f;
        GameObject newBullet = Instantiate(bullet, position, transform.rotation); // 포탄 생성
        Rigidbody2D rb = newBullet.GetComponent<Rigidbody2D>();
        rb.AddForce(power * (transform.right * 2.0f + transform.up * 0.4f));
        Instantiate(smoke, position, transform.rotation); // 연기 생성
        playGunFire();
    }

    void playGunFire()
    {
        audioSource.volume = 1.0f;
        audioSource.PlayOneShot(clipGunFire);
    }
}
