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
        if (collision.gameObject.CompareTag("Cherry"))
        {

            collectSoundEffect.Play();
            Destroy(collision.gameObject);
            scoreManager.score += cherriesScore;
        }
        
        if (collision.gameObject.CompareTag("Apple"))
        {

            collectSoundEffect.Play();
            Destroy(collision.gameObject);
            scoreManager.score += appleScore;
        }
        
        if (collision.gameObject.CompareTag("Banana"))
        {

            collectSoundEffect.Play();
            Destroy(collision.gameObject);
            scoreManager.score += bananaScore;
        }

        scores.text = string.Format("Score: {0}", scoreManager.score);
    }
}
