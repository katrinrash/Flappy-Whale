using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameFlowLogic : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public GameObject gameOverScreen;

    private int playerScore;

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        playerScore += scoreToAdd;
        scoreText.text = $"Score: {playerScore}";
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }
}
