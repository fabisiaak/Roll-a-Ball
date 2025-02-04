using UnityEngine;
using UnityEngine.UI;

public class ScoreTextHandler : MonoBehaviour
{
    private GameManager gameManager;
    private MovementController player;
    public Text scoreText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void UpdateScoreText(int score)
    {
        scoreText.text = "" + gameManager.score;
    }
}
