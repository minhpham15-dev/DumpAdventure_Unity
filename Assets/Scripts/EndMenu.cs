using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndMenu : MonoBehaviour
{
    public void Quit()
    {
        SceneManager.LoadScene("Start Menu");
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene("Level 1");
    }
}
