using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public float startTime = 30.0f;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("makeNewScene", startTime);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void makeNewScene() // public 추가: 외부에서 접근 가능
    {
        SceneManager.LoadScene("RandomBall"); // 씬 이름 추가; RandomBall로 씬이 이동
    }
}
