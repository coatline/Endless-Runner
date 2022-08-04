using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float jumpHeight;
    public float speed;
    Rigidbody2D rb;
    bool onGround;

    void Start()
    {
        speed *= 2;
        jumpHeight *= 2;
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        transform.Translate(Time.deltaTime * speed, 0, 0); 
        

        if (Input.anyKeyDown && onGround)
        {
            rb.AddForce(new Vector2(0, jumpHeight));
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            onGround = true;
        }
        else if (collision.gameObject.CompareTag("Spike"))
        {
            SceneManager.LoadScene(0);
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            onGround = false;
        }
    }
}
