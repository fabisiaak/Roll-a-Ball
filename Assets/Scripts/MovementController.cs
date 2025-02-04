using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovementController : MonoBehaviour
{
    public Rigidbody rb;
    private bool isGrounded;

    public event Action pickupEvent;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            rb.AddForce(-4f, 0, 0, ForceMode.Force);
        }

        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(4f, 0, 0, ForceMode.Force);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(0, 0, -4f, ForceMode.Force);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(0, 0, 4f, ForceMode.Force);
        }

        if (Input.GetKey(KeyCode.Escape))
        {
            Scene currentScene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(currentScene.name, LoadSceneMode.Single);
        }

        if (isGrounded && Input.GetKey(KeyCode.Space)) 
        {
            rb.AddForce(Vector3.up * 3f, ForceMode.Impulse);
            isGrounded = false;
        }
    }

    public void collectScore()
    {
        pickupEvent?.Invoke();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
}
