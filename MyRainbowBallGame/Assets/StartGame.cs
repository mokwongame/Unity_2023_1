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

    void makeNewScene()
    {
        SceneManager.LoadScene("RandomBall"); // æ¿ ¿Ã∏ß √ﬂ∞°; RandomBall∑Œ æ¿¿Ã ¿Ãµø
    }
}
