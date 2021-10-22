using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreUI;
    public float speed = 1;
    public float currentScore = 0;

    // Update is called once per frame
    void Update()
    {
        currentScore += Time.deltaTime * speed;
        scoreUI.text = "Score : " + (int)currentScore;
    }
}
