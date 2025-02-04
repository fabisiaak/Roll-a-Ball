using UnityEngine;

public class WoodenFenceUpDown : MonoBehaviour
{
    public float speed = 2;
    public float maxY = 1.5f;
    public float minY = 0f;
    private bool isUp = true;

    public GameObject fence1;
    public GameObject fence2;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 v1 = fence1.transform.position;
        Vector3 v2 = fence2.transform.position;

        float s = speed * Time.deltaTime;

        if (isUp)
        {
            v1.y += s;
            v2.y += s;

            if (v1.y >= maxY)
            {
                v1.y = maxY;
                isUp = false;
            }

            if (v2.y >= maxY)
            {
                v2.y = maxY;
                isUp = false;
            }
        }
        else
        {
            v1.y -= s;
            v2.y -= s;

            if (v1.y <= minY)
            {
                v1.y = minY;
                isUp = true;
            }

            if (v2.y <= minY)
            {
                v2.y = minY;
                isUp = true;
            }
        }

        fence1.transform.position = v1;
        fence2.transform.position = v2;
    }
}
