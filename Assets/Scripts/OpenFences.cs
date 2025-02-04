using UnityEngine;
using UnityEngine.UIElements;

public class OpenFences : MonoBehaviour
{
    private GameManager gameManager;
    public GameObject[] fences = new GameObject[3];
    private int score;
    private int fenceIndex = 0;

    MovementController player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<MovementController>();

        player.pickupEvent += openFence;
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void openFence()
    {
        score = gameManager.score;

        switch (score)
        {
            case 2:
                Debug.Log("Case 2 executed");
                fences[fenceIndex].SetActive(false);
                fenceIndex++;
                break;

            case 4:
                Debug.Log("Case 4 executed");
                fences[fenceIndex].SetActive(false);
                fenceIndex++;
                break;

            case 5:
                Debug.Log("Case 5 executed");
                fences[fenceIndex].SetActive(false);
                fenceIndex++;
                break;
            default:
                Debug.Log("No matching case");
                break;
        }
    }
}
