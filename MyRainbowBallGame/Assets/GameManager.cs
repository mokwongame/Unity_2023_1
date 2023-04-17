using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // TextMesh Pro

public class GameManager : MonoBehaviour
{
    public TMP_Text textScore;
    int score;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        textScore.text = score.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public int getScore() { return score; }

    public void incScore()
    {
        score++;
        textScore.text = score.ToString();
    }

    public void decScore()
    {
        score--;
        textScore.text = score.ToString();
    }
}
