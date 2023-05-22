using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StartScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("loadGame", 10.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void loadGame()
    {
        SceneManager.LoadScene("CannonFire");
    }
}
