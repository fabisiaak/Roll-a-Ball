using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeColorPlayerLevel3 : MonoBehaviour
{
    private Renderer sphereRenderer;

    public Color[] colors = new Color[5]
    {
        Color.red,
        Color.green,
        Color.blue,
        Color.yellow,
        Color.magenta
    };

    public int currentColorIndex = 0;

    // Start is called before the first frame update
    void Start()
    { 
        if (SceneManager.GetActiveScene().buildIndex == 3)
        {
            sphereRenderer = GetComponent<Renderer>();

            sphereRenderer.material.color = colors[0];
        }
    }

    void Update()
    {
        
    }

    public void ChangeToNextColor()
    {
        if (currentColorIndex >= 4) currentColorIndex = -1;

        currentColorIndex++;
        sphereRenderer.material.color = colors[currentColorIndex];
    }
}
