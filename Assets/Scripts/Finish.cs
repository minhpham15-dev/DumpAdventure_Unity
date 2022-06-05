using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    private AudioSource finishSound;

    private bool lvlComplete = false;

    private ScoreManager scoreManager = ScoreManager.Instance;
    private TimeManager timeManager = TimeManager.Instance;

    private void Start()
    {
        finishSound = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player" && !lvlComplete)
        {
            finishSound.Play();
            lvlComplete = true;
            Invoke("CompleteLevel", 1f);
        }
    }
    private void CompleteLevel()
    {
        int extraScore = 0;
        int timeInSeconds = Mathf.RoundToInt(timeManager.time);
        if (timeInSeconds < 10)
            extraScore = 300;
        else if (timeInSeconds < 20)
            extraScore = 200;
        else if (timeInSeconds < 30)
            extraScore = 100;
        scoreManager.score += extraScore;
        scoreManager.oldScore = scoreManager.score;

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
