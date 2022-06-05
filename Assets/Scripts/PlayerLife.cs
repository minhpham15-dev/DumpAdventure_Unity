using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerLife : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;

    [SerializeField] private AudioSource dieSoundEffect;
    [SerializeField] private Text scores;

    private ScoreManager scoreManager = ScoreManager.Instance;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        scores.text = string.Format("Cherries: {0}", scoreManager.score);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Traps"))
        {
            dieSoundEffect.Play();
            Die();
        }
    }

    private void Die()
    {
        rb.bodyType = RigidbodyType2D.Static;
        anim.SetTrigger("death");
    }

    private void RestartLevel()
    {
        scoreManager.score = scoreManager.oldScore;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
