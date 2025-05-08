using UnityEngine;

public class PipeMiddle : MonoBehaviour
{
    private ScoreManager scoreManager;
    private int playerLayer = 3; 

    private void Start()
    {
        scoreManager = GameObject.FindGameObjectWithTag("Logic").GetComponent<ScoreManager>();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == playerLayer)
        {
            scoreManager.addScore(1);
        }

    }
}
