using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class GameManager : MonoBehaviour
{
    GameObject[] collectibles;
    public int maxScore;
    public int score = 0;
    MovementController player;
    private ScoreTextHandler scoreTextHandler;

    public GameObject objectToDisable1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<MovementController>();
        collectibles = GameObject.FindGameObjectsWithTag("Point");
        maxScore = collectibles.Length;

        scoreTextHandler = GameObject.FindGameObjectWithTag("ScoreText").GetComponent<ScoreTextHandler>();

        player.pickupEvent += CollectScore;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CollectScore()
    {
        score += 1;

        if (SceneManager.GetActiveScene().buildIndex == 2 && score == 2)
        {
            objectToDisable1.SetActive(false);
        }

        if (score == maxScore)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1, LoadSceneMode.Single);
        }

        scoreTextHandler.UpdateScoreText(score);
    }
}
