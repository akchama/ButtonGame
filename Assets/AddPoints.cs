using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AddPoints : MonoBehaviour
{
    public int score;

    public TextMeshProUGUI  scoreText;
    // Start is called before the first frame update

    // Update is called once per frame
    public void Update()
    {
        scoreText.text = score.ToString();
    }

    public void AddScore()
    {
        this.score++;
    }
}