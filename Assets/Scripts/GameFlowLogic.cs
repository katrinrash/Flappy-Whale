using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameFlowLogic : MonoBehaviour
{
    public GameObject gameOverScreen;
    public GameObject menuPanel;
    public GameObject transitionManager;
    public GameObject player;

    public void Start()
    {
        gameOverScreen.SetActive(false);
    }

    public void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Escape))
        {
           menuPanel.SetActive(true);
           Time.timeScale = 0; 
        }
    }

    public void ResumeGame()
    {
        menuPanel.SetActive(false);
        Time.timeScale = 1;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void GameOver()
    {
        gameOverScreen.SetActive(true);
    }

    public void QuitGame()
    {
        Time.timeScale = 1;
        transitionManager.GetComponent<Transition>().FadeIn();
        StartCoroutine(AfterTransition());
    }

    public IEnumerator AfterTransition()
    {
        player.SetActive(false);
        yield return new WaitForSeconds(transitionManager.GetComponent<Transition>().FadeDuration);
        SceneManager.LoadScene(0);
    }
}
