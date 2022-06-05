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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Cherry"))
        {
            collectSoundEffect.Play();
            Destroy(collision.gameObject);
            scoreManager.score++;
            scores.text = string.Format("Cherries: {0}", scoreManager.score);
        }
    }
}
