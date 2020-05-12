using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public float jumpForce = 10f;
    public int jumpCount = 0;
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag != "Gift")
        {
            if (collision.relativeVelocity.y <= 0f)
            {
                Rigidbody2D ribo = collision.collider.GetComponent<Rigidbody2D>();
                if (ribo != null)
                {
                    Vector2 velocity = ribo.velocity;
                    velocity.y = jumpForce;
                    ribo.velocity = velocity;
                    ScoreScript.scoreVal += 10;

                    SoundScript.playTune("jump");

                    if (collision.gameObject.tag == "Player")
                    {
                        Destroy(gameObject);
                    }
                }
            }
        }
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
