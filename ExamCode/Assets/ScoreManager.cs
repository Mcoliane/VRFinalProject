using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
//Michael

public class ScoreManager : MonoBehaviour
{
    public int scoreValue = 0;
    public Text Score;

    public void IncrementScore()
    {
        scoreValue += 1;
        UpdateScoreDisplay();
        if (scoreValue == 3)
        {
            LoadNextScene();
        }

    }

    void Start()
    {
        UpdateScoreDisplay();
    }

    void UpdateScoreDisplay()
    {
        Score.text = "Score: " + scoreValue; 
    }

    void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = currentSceneIndex + 1;
        SceneManager.LoadScene(nextSceneIndex);
    }
}
