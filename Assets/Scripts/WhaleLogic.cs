using UnityEngine;

public class WhaleLogic : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public GameObject logicObject;
    private GameFlowLogic logic;

    public float flapStrength;
    private bool birdIsAlive = true;

    private void Start()
    {
        logic = logicObject.GetComponent<GameFlowLogic>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            myRigidbody.linearVelocity = Vector2.up * flapStrength;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
    }
}
