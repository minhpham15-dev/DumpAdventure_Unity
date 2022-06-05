using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollection : MonoBehaviour
{
    [SerializeField] private Text scores;

    [SerializeField] private AudioSource collectSoundEffect;

    private ScoreManager scoreManager = ScoreManager.Instance;

    private const int cherriesScore = 100;
    private const int appleScore = 200;
    private const int bananaScore = 300;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        bool isCollided = false;

        switch (collision.gameObject.tag)
        {
            case "Cherry":
                isCollided = true;
                scoreManager.score += cherriesScore;
                break;
            case "Apple":
                isCollided = true;
                scoreManager.score += appleScore;
                break;
            case "Banana":
                isCollided = true;
                scoreManager.score += bananaScore;
                break;
        }

        if (isCollided)
        {
            collectSoundEffect.Play();
            Destroy(collision.gameObject);
            scores.text = string.Format("Score: {0}", scoreManager.score);
        }
    }
}
