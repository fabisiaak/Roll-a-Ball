using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collectible : MonoBehaviour
{
    public Vector3 position;
    private AudioSource m_AudioSource;

    public Color coinColor;
    private Renderer coinRenderer;
    private ChangeColorPlayerLevel3 colorChanger;
    // Start is called before the first frame update
    void Start()
    {
        coinRenderer = GetComponent<Renderer>();
        m_AudioSource = GetComponent<AudioSource>();
        coinColor = coinRenderer.material.color;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(40, 40, 40) * Time.deltaTime);
    }

    void OnTriggerEnter(Collider collision)
    {
        if (SceneManager.GetActiveScene().buildIndex == 3)
        {
   
            colorChanger = GameObject.FindGameObjectWithTag("Player").GetComponent<ChangeColorPlayerLevel3>();

            if (coinColor == colorChanger.colors[colorChanger.currentColorIndex])
            {
                colorChanger.ChangeToNextColor();
                collecting();
                collision.gameObject.GetComponent<MovementController>().collectScore();
            }
        }
        else
        {
            collecting();
            collision.gameObject.GetComponent<MovementController>().collectScore();
        }
    }
    private void collecting()
    {
        m_AudioSource.Play();
        Invoke("deactivationCollectible", 2.0f);
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<BoxCollider>().enabled = false;
    }

    private void deactivationCollectible()
    {
        gameObject.SetActive(false);
    }
}

