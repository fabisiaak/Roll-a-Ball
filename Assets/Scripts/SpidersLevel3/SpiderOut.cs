using UnityEngine;
using UnityEngine.SceneManagement;

public class SpiderOot : MonoBehaviour
{
    public float speed = 2;
    public float maxZ = 29f;
    public float minZ = 25f;
    private bool isLeft = true;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 v = transform.position;

        float s = speed * Time.deltaTime;

        if (isLeft)
        {
            v.z -= s;

            if (v.z <= minZ)
            {
                v.z = minZ;
                isLeft = false;
            }
        }
        else
        {
            v.z += s;

            if (v.z >= maxZ)
            {
                v.z = maxZ;
                isLeft = true;
            }
        }

        transform.position = v;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (GameObject.FindGameObjectWithTag("Player"))
        {
            SceneManager.LoadScene(3, LoadSceneMode.Single);
        }
    }
}
