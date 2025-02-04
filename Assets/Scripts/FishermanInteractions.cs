using UnityEngine;
using UnityEngine.UI;

public class FishermanInteractions : MonoBehaviour
{
    public GameObject messagePanel;
    public GameObject fence;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Return))
        {
            messagePanel.SetActive(false);
            fence.SetActive(false);

        }
    }

    private void OnCollisionEnter(Collision other)
    {
        messagePanel.SetActive(true);
    }
}
