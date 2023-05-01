using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveCart : MonoBehaviour
{
    public float speed = 20.0f;
    public AudioSource audioSource;
    public AudioClip clipSuccess;
    public AudioClip clipFail;
    int nColor = 0; // īƮ ����; ���� �迭�� RandomBallLife.colors�� ����
    GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        // �ܺο� �ִ� ������Ʈ�� �ν��Ͻ� ã��
        gameManager = FindObjectOfType<GameManager>();
        // Renderer ã��
        Renderer rend = gameObject.GetComponent<Renderer>();
        rend.material.color = RandomBallLife.colors[nColor];
    }

    // Update is called once per frame
    void Update()
    {
        // īƮ ���� ����
        if (Input.GetKeyDown(KeyCode.Space))
        {
            nColor++; // ���� �迭�� ������ ��ġ(0~6)
            //nColor = nColor % 7;
            nColor = nColor % RandomBallLife.colors.Length; // 7 ��� �迭 ������ ������ ����
            Renderer rend = gameObject.GetComponent<Renderer>();
            rend.material.color = RandomBallLife.colors[nColor];
        }
        else if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("EndGame");
        }
        // īƮ �̵�
        //float xoff = Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime; // ���� �̵�
        //float zoff = Input.GetAxisRaw("Vertical") * speed * Time.deltaTime; // ����(3D������ z����) �̵�;
        //gameObject.transform.Translate(xoff, 0.0f, zoff);
        float xoff = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float zoff = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        Vector3 vecOff = xoff * transform.right - zoff * transform.forward;
        transform.Translate(vecOff);
    }

    // �浹(collision) �̺�Ʈ ó����
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            Renderer ballRend = collision.gameObject.GetComponent<Renderer>();
            Color ballColor = ballRend.material.color;
            // �� ���� == īƮ �����̸� ����, �ƴϸ� ����
            if (ballColor == RandomBallLife.colors[nColor])
            {
                gameManager.incScore(); // score = score + 1
                playCartSuccess();
            }
            else
            {
                gameManager.decScore();   // score = score - 1
                playCartFail();
            }
            Debug.Log("score = " + gameManager.getScore()); // �ֿܼ��� �α� ����
            Destroy(collision.gameObject, 0.1f); // �浹�� ball�� 0.1�� �Ŀ� �ı�
        }
    }

    void playCartSuccess()
    {
        audioSource.volume = 0.9f; // ���� 90%; 100% ���ϸ� 1.0f �Է�
        audioSource.PlayOneShot(clipSuccess); // ������ ȿ����
    }

    void playCartFail()
    {
        audioSource.volume = 0.9f;
        audioSource.PlayOneShot(clipFail); // ���н� ȿ����
    }
}