using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{

    public GameObject gameOverCanvas;
    AudioSource audioSource;
    private void Start()
    {
        Time.timeScale = 1;
        gameOverCanvas.SetActive(false);
        audioSource = GetComponent<AudioSource>();
    }

    public void GameOver()
    {
       
        gameOverCanvas.SetActive(true);
        Time.timeScale = 0;
        audioSource.Play();
    }
    public void Replay()
    {
        SceneManager.LoadScene(0);
    }

}
