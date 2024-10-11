using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using GameJolt.API;
using GameJolt.API.Objects;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    private float timer;
    private int score;
    public static GameManager Instance { get { return instance; } }

    private void Awake()
    {
        instance = this;
    }

    private void Update()
    {
        timer+=Time.deltaTime;
        if (timer > score)
        {
            score++;
            ScoreUi.Instance.UpdateScore(score);
        }
    }

    public void GameOver()
    { 
        Scores.Add(score, $"Score: {score}", 941587, "", OnCallback);
    }

    private void OnCallback(bool success)
    {
        SceneManager.LoadScene("GameOverScene");
    }
}
