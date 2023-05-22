using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TMP_Text scoreText;
    int score = 20;
    // Start is called before the first frame update
    void Start()
    {
        writeScore();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int getScore() { return score; }
    public void incScore() { score++; writeScore(); }
    public void decScore() { score--; writeScore(); }
    public void writeScore() { scoreText.text = score.ToString(); }

}
