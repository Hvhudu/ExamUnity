using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float JumpForce;
    public Rigidbody2D rb;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            rb.AddForce(transform.up*JumpForce,ForceMode2D.Impulse);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Pipepart"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }    
    }
}
