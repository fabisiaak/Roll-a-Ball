using UnityEngine;

public class TeleportController : MonoBehaviour
{
    MovementController player;
    private int teleportIndex = 0;
    public Transform teleportTarget;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<MovementController>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        player.transform.position = teleportTarget.position;
        teleportIndex++;
    }
}
