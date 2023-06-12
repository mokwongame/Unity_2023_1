using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TMP_Text textScore;
    int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        showScore();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void incScore()
    {
        score++;
        showScore();
    }

    void showScore()
    {
        textScore.text = score.ToString();
    }
}
