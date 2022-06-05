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
        scoreManager.oldScore = scoreManager.score;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
